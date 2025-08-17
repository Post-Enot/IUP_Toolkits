using System;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace IUP.Toolkits.Editor.UI
{
    [UxmlElement(libraryPath = "IUP Editor")]
    public partial class ClassNameField : VisualElement
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

        public static readonly string Uss = "iup-class-name-field";
        public static readonly string UssInput = "iup-class-name-field__input";

        public event Action<string> ValueChanged;

        private readonly TextField _inputField;
        private readonly HelpBox _helpBox;

        public ClassNameField()
        {
            _inputField = new TextField();
            _inputField.RegisterValueChangedCallback(OnValueChanged);
            _helpBox = new HelpBox()
            {
                messageType = HelpBoxMessageType.Error
            };
            Add(_inputField);
            AddToClassList(Uss);
            _inputField.AddToClassList(UssInput);
        }

        public void BindProperty(SerializedProperty property) => _inputField.BindProperty(property);

        public bool IsValueValid() => CodeGeneratorUtility.IsValidID(Value);

        public bool IsValueInvalid() => CodeGeneratorUtility.IsInvalidID(Value);

        private void OnValueChanged(ChangeEvent<string> context)
        {
            ValueChanged?.Invoke(Value);
            UpdateHelpBox();
        }

        private void UpdateHelpBox()
        {
            if (GetValidationMessage(Value, out string message))
            {
                if (Contains(_helpBox))
                {
                    return;
                }
                _helpBox.text = message;
                Add(_helpBox);
            }
            else
            {
                if (Contains(_helpBox))
                {
                    Remove(_helpBox);
                }
            }
        }

        private static bool GetValidationMessage(string className, out string message)
        {
            if (string.IsNullOrEmpty(className))
            {
                message = "Class name cannot be empty.";
                return true;
            }
            char firstChar = className[0];
            if (CodeGeneratorUtility.IsInvalidIDFirstChar(firstChar))
            {
                message = "Class name first char should be letter, \"_\" or \"@\".";
                return true;
            }
            ReadOnlySpan<char> chars = className.AsSpan()[1..];
            if (CodeGeneratorUtility.IsInvalidIDChars(chars))
            {
                message = "Class name should contains only letter, digit or \"_\".";
                return true;
            }
            message = null;
            return false;
        }
    }
}
