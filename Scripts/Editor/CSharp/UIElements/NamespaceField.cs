using System;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace IUP.Toolkits.Editor.UI
{
    [UxmlElement(libraryPath = "IUP Editor")]
    public partial class NamespaceField : VisualElement
    {
        [UxmlAttribute]
        public string Label
        {
            get => _inputField.label;
            set => _inputField.label = value;
        }

        [UxmlAttribute]
        public string Placeholder
        {
            get => _inputField.textEdition.placeholder;
            set => _inputField.textEdition.placeholder = value;
        }

        [UxmlAttribute]
        public string Value
        {
            get => _inputField.value;
            set => _inputField.value = value;
        }

        public static readonly string Uss = "iup-namespace-field";
        public static readonly string UssInput = "iup-namespace-field__input";
        public static readonly string UssHelpBox = "iup-namespace-field__help-box";

        public event Action<string> ValueChanged;

        private readonly TextField _inputField;
        private readonly HelpBox _helpBox;

        public NamespaceField()
        {
            _inputField = new TextField();
            _inputField.RegisterValueChangedCallback(OnValueChanged);
            _helpBox = new HelpBox
            {
                messageType = HelpBoxMessageType.Error
            };
            _helpBox.AddToClassList(UssHelpBox);

            Add(_inputField);
            AddToClassList(Uss);
            _inputField.AddToClassList(UssInput);
        }

        public void BindProperty(SerializedProperty property) => _inputField.BindProperty(property);

        public bool IsValueValid()
        {
            if (Value == null)
            {
                return false;
            }
            return CodeGeneratorUtility.IsValidNamespace(Value);
        }
        public bool IsValueInvalid() => !IsValueValid();

        private void OnValueChanged(ChangeEvent<string> context)
        {
            ValueChanged?.Invoke(Value);
            UpdateHelpBox();
        }

        private void UpdateHelpBox()
        {
            if (IsValueInvalid())
            {
                if (!Contains(_helpBox))
                {
                    Add(_helpBox);
                }
                _helpBox.text = "Value should be valid C# namespace.";
            }
            else if (Contains(_helpBox))
            {
                Remove(_helpBox);
            }
        }
    }
}
