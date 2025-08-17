using UnityEngine;

namespace IUP.Toolkits
{
    public static class ExtensionRectTransform
    {
        public static void SetSizeWithCurrentAnchors(this RectTransform self, Vector2 size)
        {
            self.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, size.x);
            self.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, size.y);
        }

        public static void SetLocalEulerZ(this RectTransform self, float z) =>
            self.localRotation = Quaternion.Euler(0.0f, 0.0f, z);
    }
}
