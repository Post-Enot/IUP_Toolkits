using UnityEngine;

namespace IUP.Toolkits
{
    public static class IUP_Easing
    {
        public static float InOutSine(float t) => -(Mathf.Cos(IUP_Math.PI * t) - 1.0f) / 2.0f;
    }
}
