using UnityEngine;

namespace IUP.Toolkits
{
    public static class ExtensionLayerMask
    {
        public static bool Contains(this LayerMask self, int layer) => Bits.IsSet(self, layer);
    }
}
