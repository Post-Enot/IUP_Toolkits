using System;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace IUP.Toolkits.Editor
{
    public sealed class TypeAdvancedDropdown : AdvancedDropdown
    {
        public TypeAdvancedDropdown(
            IReadOnlyList<TypeViewData> typesViewData,
            Action<Type> onSelected,
            string header) : base(new AdvancedDropdownState())
        {
            _typesViewData = typesViewData;
            _onSelected = onSelected;
            _header = header;
            minimumSize = new Vector2(250.0f, 300.0f);
        }

        private readonly Action<Type> _onSelected;
        private readonly string _header;
        private readonly IReadOnlyList<TypeViewData> _typesViewData;

        public void ShowToList(Rect listRect)
        {
            Vector2 size = listRect.size;
            size.x = minimumSize.x;
            Vector2 position = listRect.position;
            position.x = listRect.xMax - size.x;
            Rect rect = new(position, size);
            Show(rect);
        }

        protected override void ItemSelected(AdvancedDropdownItem item)
        {
            TypeViewData data = _typesViewData[item.id];
            _onSelected(data.Type);
        }

        protected override AdvancedDropdownItem BuildRoot()
        {
            AdvancedDropdownItem root = new(_header);
            for (int i = 0; i < _typesViewData.Count; i += 1)
            {
                TypeViewData data = _typesViewData[i];
                InsertNode(root, data, i);
            }
            return root;
        }

        private static void InsertNode(AdvancedDropdownItem root, TypeViewData data, int index)
        {
            string[] pathParts = data.Name.Split('/', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < pathParts.Length; i += 1)
            {
                string part = pathParts[i];
                AdvancedDropdownItem existingItem = TryGetChildByName(root, part);
                if (existingItem == null)
                {
                    existingItem = new AdvancedDropdownItem(part)
                    {
                        id = (i == (pathParts.Length - 1)) ? index : -1
                    };
                    root.AddChild(existingItem);
                }
                root = existingItem;
            }
        }

        private static AdvancedDropdownItem TryGetChildByName(
            AdvancedDropdownItem parent,
            string childName)
        {
            if (parent.children == null)
            {
                return null;
            }
            foreach (AdvancedDropdownItem child in parent.children)
            {
                if (child.name == childName)
                {
                    return child;
                }
            }
            return null;
        }
    }
}
