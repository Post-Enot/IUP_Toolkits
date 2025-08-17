using System.IO;
using IUP.Toolkits.Editor.UI;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

namespace IUP.Toolkits.Editor
{
    [CustomEditor(typeof(InputEventsWrapperAsset))]
    public sealed class InputEventsWrapperAssetEditor : UnityEditor.Editor
    {
        [SerializeField] private VisualTreeAsset _visualTreeAsset;

        private ObjectField _inputAssetField;
        private FileField _eventsFileField;
        private NamespaceField _eventsNamespaceField;
        private ClassNameField _eventsClassNameField;
        private FileField _facadeFileField;
        private NamespaceField _facadeNamespaceField;
        private ClassNameField _facadeClassNameField;
        private Button _buttonGenerateCode;

        public override VisualElement CreateInspectorGUI()
        {
            InputEventsWrapperAsset config = target as InputEventsWrapperAsset;

            SerializedProperty inputActionAssetProperty =
                serializedObject.FindProperty("_inputActionAsset");
            SerializedProperty eventsFilePathProperty =
                serializedObject.FindProperty("_eventsFilePath");
            SerializedProperty eventsClassNameProperty =
                serializedObject.FindProperty("_eventsClassName");
            SerializedProperty eventsNamespaceProperty =
                serializedObject.FindProperty("_eventsNamespace");
            SerializedProperty facadeFilePathProperty =
                serializedObject.FindProperty("_facadeFilePath");
            SerializedProperty facadeClassNameProperty =
                serializedObject.FindProperty("_facadeClassName");
            SerializedProperty facadeNamespaceProperty =
                serializedObject.FindProperty("_facadeNamespace");

            InputActionAsset inputActionAsset =
                inputActionAssetProperty.objectReferenceValue as InputActionAsset;

            var root = _visualTreeAsset.Instantiate();
            _inputAssetField = root.Q<ObjectField>("input-asset-field");
            _eventsFileField = root.Q<FileField>("events-file-field");
            _eventsNamespaceField = root.Q<NamespaceField>("events-namespace-field");
            _eventsClassNameField = root.Q<ClassNameField>("events-class-name-field");
            _facadeFileField = root.Q<FileField>("facade-file-field");
            _facadeNamespaceField = root.Q<NamespaceField>("facade-namespace-field");
            _facadeClassNameField = root.Q<ClassNameField>("facade-class-name-field");
            _buttonGenerateCode = root.Q<Button>("generate-code-button");

            _eventsFileField.ValueChanged += OnValueChanged;
            _eventsNamespaceField.ValueChanged += OnValueChanged;
            _eventsClassNameField.ValueChanged += OnValueChanged;
            _eventsFileField.ValueChanged += OnValueChanged;
            _facadeNamespaceField.ValueChanged += OnValueChanged;
            _facadeClassNameField.ValueChanged += OnValueChanged;
            _buttonGenerateCode.clicked += OnGenerateCodeButtonClicked;
            _inputAssetField.RegisterValueChangedCallback(OnInputAssetFieldValueChanged);

            _inputAssetField.BindProperty(inputActionAssetProperty);
            _eventsFileField.BindProperty(eventsFilePathProperty);
            _eventsNamespaceField.BindProperty(eventsNamespaceProperty);
            _eventsClassNameField.BindProperty(eventsClassNameProperty);
            _facadeFileField.BindProperty(facadeFilePathProperty);
            _facadeNamespaceField.BindProperty(facadeNamespaceProperty);
            _facadeClassNameField.BindProperty(facadeClassNameProperty);
            return root;
        }

        private void OnDestroy()
        {
            _inputAssetField.UnregisterValueChangedCallback(OnInputAssetFieldValueChanged);
            _eventsFileField.ValueChanged -= OnValueChanged;
            _eventsNamespaceField.ValueChanged -= OnValueChanged;
            _eventsClassNameField.ValueChanged -= OnValueChanged;
            _eventsFileField.ValueChanged -= OnValueChanged;
            _facadeNamespaceField.ValueChanged -= OnValueChanged;
            _facadeClassNameField.ValueChanged -= OnValueChanged;
            _buttonGenerateCode.clicked -= OnGenerateCodeButtonClicked;
        }

        private void OnInputAssetFieldValueChanged(ChangeEvent<Object> context)
            => UpdateButtonState();

        private void OnValueChanged(string value) => UpdateButtonState();

        private void UpdateButtonState()
            => _buttonGenerateCode.enabledSelf = (_inputAssetField.value != null) &&
                _eventsFileField.IsValueValid() &&
                _eventsNamespaceField.IsValueValid() &&
                _eventsClassNameField.IsValueValid() &&
                _facadeFileField.IsValueValid() &&
                _facadeNamespaceField.IsValueValid() &&
                _facadeClassNameField.IsValueValid();

        private void OnGenerateCodeButtonClicked()
        {
            GenerateInputEvents(
                _eventsFileField.Value,
                _eventsNamespaceField.Value,
                _eventsClassNameField.Value);
            GenerateInputFacade(
                _facadeFileField.Value,
                _facadeNamespaceField.Value,
                _facadeClassNameField.Value,
                _eventsNamespaceField.Value,
                _eventsClassNameField.Value);
            AssetDatabase.Refresh();
        }

        private void GenerateInputEvents(
            string path,
            string classNamespace,
            string className)
        {
            string code = InputEventsGenerator.GenerateCode(
                _inputAssetField.value as InputActionAsset,
                classNamespace,
                className);
            SaveToFile(code, path);
        }

        private void GenerateInputFacade(
            string path,
            string classNamespace,
            string className,
            string eventsClassNamespace,
            string eventsClassName)
        {
            string code = InputFacadeGenerator.GenerateCode(
                _inputAssetField.value as InputActionAsset,
                classNamespace,
                className,
                eventsClassNamespace,
                eventsClassName);
            SaveToFile(code, path);
        }

        private static void SaveToFile(string content, string path)
        {
            path = TrimFirstPathSegment(path);
            string fullPath = Path.Combine(Application.dataPath, path);
            File.WriteAllText(fullPath, content);
        }

        private static string TrimFirstPathSegment(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return string.Empty;
            }

            int index = path.IndexOf('/');
            if (index == -1)
            {
                index = path.IndexOf('\\');
            }
            int start = index + 1;
            return index >= 0 ? path[start..] : string.Empty;
        }
    }
}
