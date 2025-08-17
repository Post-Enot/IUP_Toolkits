using UnityEditor;
using UnityEngine;

namespace IUP.Toolkits.Editor
{
    public abstract class AssetEditorWindow<TAsset> : EditorWindow where TAsset : ScriptableObject
    {
        [SerializeField] private TAsset _asset;

        public TAsset Asset
        {
            get => _asset;
            set => _asset = value;
        }

        public void UpdateTitle(string titleNoAsset)
        {
            if (Asset != null)
            {
                titleContent.text = Asset.name;
            }
            else
            {
                titleContent.text = titleNoAsset;
            }
        }

        public static bool DefaultOnOpenAsset<TAssetEditorWindow>(int instanceID)
            where TAssetEditorWindow : AssetEditorWindow<TAsset>
            => EditorWindowUtility.DefaultOnOpenAsset<TAsset, TAssetEditorWindow>(instanceID);
    }
}
