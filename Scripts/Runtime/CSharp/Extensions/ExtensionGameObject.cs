using UnityEngine;

namespace IUP.Toolkits
{
    public static class ExtensionGameObject
    {
        public static void SetLayerRecursively(this GameObject self, int layer)
        {
            for (int i = 0; i < self.transform.childCount; i += 1)
            {
                Transform child = self.transform.GetChild(i);
                child.gameObject.layer = layer;
            }
        }
    }
}
