using System;
using UnityEngine;

namespace IUP.Toolkits
{
    [Serializable]
    public sealed class Vector3SmoothDamp
    {
        public Vector3SmoothDamp() { }

        [SerializeField, Min(0.0f)] private float _smoothTime = 0.1f;
        [SerializeField] private Vector3 _current;
        [SerializeField] private Vector3 _target;

        public Vector3 Current
        {
            get => _current;
            set => _current = value;
        }
        public Vector3 Target
        {
            get => _target;
            set => _target = value;
        }
        public float SmoothTime
        {
            get => _smoothTime;
            set => _smoothTime = value;
        }

        public Vector3 Velocity => _velocity;

        private Vector3 _velocity;

        public void Init(Vector3 value)
        {
            Current = value;
            Target = value;
        }

        public void Init(Vector3 current, Vector3 target)
        {
            Current = current;
            Target = target;
        }

        public Vector3 Update(Vector3 target)
        {
            Target = target;
            Current = Vector3.SmoothDamp(Current, Target, ref _velocity, SmoothTime);
            return Current;
        }

        public Vector3 Update()
        {
            Current = Vector3.SmoothDamp(Current, Target, ref _velocity, SmoothTime);
            return Current;
        }
    }
}
