using UnityEngine;

namespace IUP.Toolkits
{
    public static class ExtensionMonoBehaviour
    {
        public static void Enable(this MonoBehaviour self) => self.enabled = true;

        public static void Disable(this MonoBehaviour self) => self.enabled = false;
    }
}
