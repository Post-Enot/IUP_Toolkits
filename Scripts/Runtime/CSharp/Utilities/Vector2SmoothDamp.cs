using UnityEngine;

namespace IUP.Toolkits
{
    public class Vector2SmoothDamp
    {
        public Vector2 Current { get; set; }
        public Vector2 Target { get; set; }

        public Vector2 Velocity => _velocity;

        private Vector2 _velocity;

        public Vector2 Update(float smoothTime, Vector2 target)
        {
            Target = target;
            Current = Vector2.SmoothDamp(Current, Target, ref _velocity, smoothTime);
            return Current;
        }

        public Vector2 Update(float smoothTime)
        {
            Current = Vector2.SmoothDamp(Current, Target, ref _velocity, smoothTime);
            return Current;
        }
    }
}
