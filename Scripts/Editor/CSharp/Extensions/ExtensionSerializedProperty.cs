using UnityEditor;

namespace IUP.Toolkits.Editor
{
    public static class ExtensionSerializedProperty
    {
        public static SerializedProperty InsertArrayElementAt(
            this SerializedProperty self,
            int index)
        {
            self.InsertArrayElementAtIndex(index);
            return self.GetArrayElementAtIndex(index);
        }

        public static SerializedProperty InsertArrayElementAtEnd(this SerializedProperty self)
        {
            int index = self.arraySize;
            self.InsertArrayElementAtIndex(index);
            return self.GetArrayElementAtIndex(index);
        }
    }
}
