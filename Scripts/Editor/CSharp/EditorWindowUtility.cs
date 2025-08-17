using UnityEditor;
using UnityEngine;

namespace IUP.Toolkits.Editor
{
    public static class EditorWindowUtility
    {
        public static bool TryFindEditorForAsset<TAsset, TAssetEditorWindow>(
            TAsset asset,
            out TAssetEditorWindow window)
            where TAsset : ScriptableObject
            where TAssetEditorWindow : AssetEditorWindow<TAsset>
        {
            TAssetEditorWindow[] windows = Resources.FindObjectsOfTypeAll<TAssetEditorWindow>();
            foreach (TAssetEditorWindow iWindow in windows)
            {
                if (iWindow.Asset == asset)
                {
                    window = iWindow;
                    return true;
                }
            }
            window = null;
            return false;
        }

        public static TAssetEditorWindow FindOrCreateEditorForAsset<TAsset, TAssetEditorWindow>(
            TAsset asset)
            where TAsset : ScriptableObject
            where TAssetEditorWindow : AssetEditorWindow<TAsset>
        {
            if (TryFindEditorForAsset(asset, out TAssetEditorWindow window))
            {
                return window;
            }
            window = ScriptableObject.CreateInstance<TAssetEditorWindow>();
            window.Asset = asset;
            return window;
        }

        public static TAssetEditorWindow OpenEditorForAsset<TAsset, TAssetEditorWindow>(
            TAsset asset)
            where TAsset : ScriptableObject
            where TAssetEditorWindow : AssetEditorWindow<TAsset>
        {
            TAssetEditorWindow window = FindOrCreateEditorForAsset<TAsset, TAssetEditorWindow>(
                asset);
            window.Show();
            window.Focus();
            return window;
        }

        public static bool DefaultOnOpenAsset<TAsset, TAssetEditorWindow>(int instanceID)
            where TAsset : ScriptableObject
            where TAssetEditorWindow : AssetEditorWindow<TAsset>
        {
            if (EditorUtility.InstanceIDToObject(instanceID) is TAsset asset)
            {
                _ = OpenEditorForAsset<TAsset, TAssetEditorWindow>(asset);
                return true;
            }
            return false;
        }
    }
}
