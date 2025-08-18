using UnityEngine;

namespace IUP.Toolkits
{
    public static class ExtensionEnableDisable
    {
        #region Enable
        public static void Enable(this Behaviour self) => self.enabled = true;

        public static void Enable(this MonoBehaviour self) => self.enabled = true;

        public static bool Enable(this Collider self) => self.enabled = true;

        public static void Enable(this GameObject self) => self.SetActive(true);
        #endregion

        #region Disable
        public static void Disable(this Behaviour self) => self.enabled = false;

        public static void Disable(this MonoBehaviour self) => self.enabled = false;

        public static bool Disable(this Collider self) => self.enabled = false;

        public static void Disable(this GameObject self) => self.SetActive(false);
        #endregion

        #region IsEnabled
        public static bool IsEnabled(this Behaviour self) => self.enabled;

        public static bool IsEnabled(this MonoBehaviour self) => self.enabled;

        public static bool IsEnabled(this Collider self) => self.enabled;
        #endregion

        #region IsDisabled
        public static bool IsDisabled(this Behaviour self) => !self.enabled;

        public static bool IsDisabled(this MonoBehaviour self) => !self.enabled;

        public static bool IsDisabled(this Collider self) => !self.enabled;
        #endregion
    }
}
