using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace IUP.Toolkits.Editor
{
    [CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
    public sealed class ReadOnlyDrawer : PropertyDrawer
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            PropertyField field = new(property);
            field.SetEnabled(false);
            return field;
        }
    }
}
