using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace IUP.Toolkits.Editor
{
    public sealed class ChangeIDPopupContent : PopupWindowContent
    {
        public ChangeIDPopupContent(
            VisualTreeAsset visualTreeAsset,
            StyleSheet styleSheet,
            Func<string, bool> isValidID,
            Func<string, bool> isUniqueID,
            Func<string, string, bool> tryChangeID,
            string oldID)
        {
            _visualTreeAsset = visualTreeAsset;
            _styleSheet = styleSheet;
            _isValidID = isValidID;
            _isUniqueID = isUniqueID;
            _tryChangeID = tryChangeID;
            _oldID = oldID;
        }

        private readonly VisualTreeAsset _visualTreeAsset;
        private readonly StyleSheet _styleSheet;
        private readonly Func<string, bool> _isValidID;
        private readonly Func<string, bool> _isUniqueID;
        private readonly Func<string, string, bool> _tryChangeID;
        private readonly string _oldID;

        private Button _buttonCancel;
        private Button _buttonChangeID;
        private TextField _fieldNewID;

        public override void OnOpen()
        {
            WindowSize = new Vector2(300.0f, 60.0f);
            _visualTreeAsset.CloneTree(editorWindow.rootVisualElement);
            editorWindow.rootVisualElement.styleSheets.Add(_styleSheet);
            InitViewReferences();
            SubscribeOnEvents();
        }

        private void InitViewReferences()
        {
            _buttonCancel = editorWindow.rootVisualElement.Q<Button>("cancel-button");
            _buttonChangeID = editorWindow.rootVisualElement.Q<Button>("change-id-button");
            _fieldNewID = editorWindow.rootVisualElement.Q<TextField>("new-id-field");
        }

        private void SubscribeOnEvents()
        {
            _buttonCancel.clicked += OnCancelButtonClicked;
            _buttonChangeID.clicked += OnChangeIDButtonClicked;
            _fieldNewID.RegisterValueChangedCallback(OnNewIDFieldValueChanged);
        }

        private void OnChangeIDButtonClicked()
        {
            string newID = _fieldNewID.value;
            if (_isValidID(newID) && _tryChangeID(_oldID, newID))
            {
                editorWindow.Close();
            }
        }

        private void OnCancelButtonClicked() => editorWindow.Close();

        private void OnNewIDFieldValueChanged(ChangeEvent<string> context)
        {
            bool canCreate = _isValidID(context.newValue) && _isUniqueID(context.newValue);
            _buttonChangeID.SetEnabled(canCreate);
        }
    }
}
