using UnityEngine;

namespace IUP.Toolkits
{
    public static class ExtensionAnimator
    {
        public static void SetVector2(
            this Animator self,
            string nameX,
            string nameY,
            Vector2 value)
        {
            self.SetFloat(nameX, value.x);
            self.SetFloat(nameY, value.y);
        }

        public static Vector2 GetVector2(this Animator self, string nameX, string nameY)
        {
            float x = self.GetFloat(nameX);
            float y = self.GetFloat(nameY);
            return new Vector2(x, y);
        }
    }
}
