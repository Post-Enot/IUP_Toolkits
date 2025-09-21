using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace IUP.Toolkits.Editor
{
    public abstract class BaseEvenManipulatorPropertyDrawer : PropertyDrawer
    {
        private const string _propertyPath = "_eventBusReference";

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            VisualElement container = new();
            SerializedProperty eventBusProperty = property.FindPropertyRelative(_propertyPath);
            if (eventBusProperty != null)
            {
                PropertyField field = new(eventBusProperty)
                {
                    label = property.displayName
                };
                container.Add(field);
            }
            else
            {
                string warningMessage = $"Can't find property relative: {_propertyPath}";
                Debug.Log(warningMessage);
                Label labelWarning = new(warningMessage);
                container.Add(labelWarning);
            }
            return container;
        }
    }
}
