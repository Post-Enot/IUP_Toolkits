using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;

namespace IUP.Toolkits.Editor
{
    public static class ExtensionSerializedProperty
    {
        public static Type GetElementType(this SerializedProperty property)
        {
            if (!property.isArray)
            {
                return null;
            }
            Type hostType = property.serializedObject.targetObject.GetType();
            FieldInfo fieldInfo = GetFieldInfo(hostType, property.propertyPath);
            if (fieldInfo == null)
            {
                return null;
            }
            if (fieldInfo.FieldType.IsArray)
            {
                return fieldInfo.FieldType.GetElementType();
            }
            Type genericTypeDefinition = fieldInfo.FieldType.GetGenericTypeDefinition();
            if (fieldInfo.FieldType.IsGenericType && (genericTypeDefinition == typeof(List<>)))
            {
                Type[] genericArgumentTypes = fieldInfo.FieldType.GetGenericArguments();
                return genericArgumentTypes[0];
            }
            return null;
        }

        private static FieldInfo GetFieldInfo(Type type, string path)
        {
            FieldInfo fieldInfo = null;
            string[] pathParts = path.Split('.');
            for (int i = 0; i < pathParts.Length; i += 1)
            {
                string part = pathParts[i];
                if (part == "Array" || part.Contains("["))
                {
                    continue;
                }
                fieldInfo = type.GetField(
                    part,
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

                if (fieldInfo == null)
                {
                    Type currentType = type;
                    while ((fieldInfo == null) && (currentType != null))
                    {
                        fieldInfo = currentType.GetField(
                            part,
                            BindingFlags.Instance | BindingFlags.NonPublic);
                        currentType = currentType.BaseType;
                    }
                    if (fieldInfo == null)
                    {
                        return null;
                    }
                }
                type = fieldInfo.FieldType;
            }
            return fieldInfo;
        }

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
