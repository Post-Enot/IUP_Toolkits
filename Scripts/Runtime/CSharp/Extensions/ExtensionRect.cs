using UnityEngine;

namespace IUP.Toolkits
{
    public static class ExtensionRect
    {
        public static void Encapsulate(ref this Rect rect, Vector2 point)
        {
            float minX = IUP_Math.Min(rect.xMin, point.x);
            float minY = IUP_Math.Min(rect.yMin, point.y);
            float maxX = IUP_Math.Max(rect.xMax, point.x);
            float maxY = IUP_Math.Max(rect.yMax, point.y);
            rect.x = minX;
            rect.y = minY;
            rect.width = maxX - minX;
            rect.height = maxY - minY;
        }

        public static Vector2 Clamp(this Rect rect, Vector2 point)
            => IUP_Math.Clamp(point, rect.min, rect.max);
    }
}
