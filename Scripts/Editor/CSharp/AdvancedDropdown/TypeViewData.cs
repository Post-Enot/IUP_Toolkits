using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace IUP.Toolkits.Editor
{
    public sealed class TypeViewData
    {
        public TypeViewData(Type type)
        {
            Type = type;
            object[] attributes = type.GetCustomAttributes(false);
            foreach (object attribute in attributes)
            {
                if (attribute is TypeViewAttribute view)
                {
                    Name = view.Name;
                    return;
                }
            }
            Name = ObjectNames.NicifyVariableName(type.Name);
        }

        public TypeViewData(Type type, string name, Texture2D icon = null)
        {
            Type = type;
            Name = name;
            Icon = icon;
        }

        public Type Type { get; }
        public string Name { get; }
        public Texture2D Icon { get; }

        public static List<TypeViewData> GetFor<T>(HashSet<Type> blacklist = null)
        {
            Type baseType = typeof(T);
            return GetFor(baseType, blacklist);
        }

        public static List<TypeViewData> GetFor(Type baseType, HashSet<Type> blacklist = null)
        {
            List<TypeViewData> typesViewData = new();
            blacklist ??= new HashSet<Type>();
            TypeCache.TypeCollection types = TypeCache.GetTypesDerivedFrom(baseType);
            foreach (Type type in types)
            {
                if (blacklist.Contains(type) || type.IsAbstract)
                {
                    continue;
                }
                TypeViewData data = new(type);
                typesViewData.Add(data);
            }
            typesViewData.Sort(Comprasion);
            return typesViewData;
        }

        public static int Comprasion(TypeViewData a, TypeViewData b)
            => string.Compare(a.Name, b.Name, StringComparison.Ordinal);
    }
}
