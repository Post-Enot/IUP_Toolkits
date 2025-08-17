using UnityEngine;

namespace IUP.Toolkits
{
    public static class ExtensionEnableDisable
    {
        public static void Enable(this Behaviour self) => self.enabled = true;

        public static void Disable(this Behaviour self) => self.enabled = false;

        public static bool IsEnabled(this Behaviour self) => self.enabled;

        public static bool IsDisabled(this Behaviour self) => !self.enabled;

        public static bool Enable(this Collider self) => self.enabled = true;

        public static bool Disable(this Collider self) => self.enabled = false;

        public static void Enable(this GameObject self) => self.SetActive(true);

        public static void Disable(this GameObject self) => self.SetActive(false);

        public static bool IsEnabledSelf(this GameObject self) => self.activeSelf;

        public static bool IsDisabledSelf(this GameObject self) => !self.activeSelf;

        public static bool IsEnabledHierarchy(this GameObject self) => self.activeInHierarchy;

        public static bool IsDisabledHierarchy(this GameObject self) => !self.activeInHierarchy;
    }
}
