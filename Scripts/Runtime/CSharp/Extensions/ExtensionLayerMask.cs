using UnityEngine;

namespace IUP.Toolkits
{
    public static class ExtensionLayerMask
    {
        public static bool Contains(this LayerMask self, int layer)
        {
            int flag = layer.BitFlag();
            return (flag & self.value) == flag;
        }
    }
}
