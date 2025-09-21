using UnityEngine;

namespace IUP.Toolkits
{
    public sealed class UnityTimeProvider : ITimeProvider
    {
        public float GetCurrentTime() => Time.time;
    }
}
