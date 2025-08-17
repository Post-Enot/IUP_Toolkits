using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace IUP.Toolkits.Editor
{
    public sealed class CreateAssetPopupContent : PopupWindowContent
    {
        public CreateAssetPopupContent(
            VisualTreeAsset visualTreeAsset,
            StyleSheet styleSheet,
            Func<string, bool> isValidID,
            Func<string, bool> isUniqueID,
            Func<string, bool> tryCreate)
        {
            _visualTreeAsset = visualTreeAsset;
            _styleSheet = styleSheet;
            _isValidID = isValidID;
            _isUniqueID = isUniqueID;
            _tryCreate = tryCreate;
        }

        private readonly VisualTreeAsset _visualTreeAsset;
        private readonly StyleSheet _styleSheet;
        private readonly Func<string, bool> _isValidID;
        private readonly Func<string, bool> _isUniqueID;
        private readonly Func<string, bool> _tryCreate;

        private TextField _fieldID;
        private Button _buttonCancel;
        private Button _buttonCreate;

        public override void OnOpen()
        {
            WindowSize = new Vector2(300.0f, 60.0f);
            InitRoot();
            InitViewReferences();
            SubscribeOnEvents();
        }

        private void InitRoot()
        {
            _visualTreeAsset.CloneTree(editorWindow.rootVisualElement);
            editorWindow.rootVisualElement.styleSheets.Add(_styleSheet);
        }

        private void InitViewReferences()
        {
            _fieldID = editorWindow.rootVisualElement.Q<TextField>("id-field");
            _buttonCancel = editorWindow.rootVisualElement.Q<Button>("cancel-button");
            _buttonCreate = editorWindow.rootVisualElement.Q<Button>("create-button");
        }

        private void SubscribeOnEvents()
        {
            _fieldID.RegisterValueChangedCallback(OnIdFieldValueChanged);
            _buttonCancel.clicked += OnCancelButtonClicked;
            _buttonCreate.clicked += OnCreateButtonClicked;
        }

        private void OnIdFieldValueChanged(ChangeEvent<string> context)
        {
            bool canCreate = _isValidID(context.newValue) && _isUniqueID(context.newValue);
            _buttonCreate.SetEnabled(canCreate);
        }

        private void OnCancelButtonClicked() => editorWindow.Close();

        private void OnCreateButtonClicked()
        {
            string definitionID = _fieldID.value;
            if (_isValidID(definitionID) && _tryCreate(definitionID))
            {
                editorWindow.Close();
            }
        }
    }
}
