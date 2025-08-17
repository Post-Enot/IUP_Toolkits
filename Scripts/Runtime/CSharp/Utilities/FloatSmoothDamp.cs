using System;
using UnityEngine;

namespace IUP.Toolkits
{
    [Serializable]
    public sealed class FloatSmoothDamp
    {
        public FloatSmoothDamp() {}

        [SerializeField, Min(0.0f)] private float _smoothTime = 0.1f;
        [SerializeField] private float _current;
        [SerializeField] private float _target;

        public float Current
        {
            get => _current;
            set => _current = value;
        }
        public float Target
        {
            get => _target;
            set => _target = value;
        }
        public float SmoothTime
        {
            get => _smoothTime;
            set => _smoothTime = value;
        }

        public float Velocity => _velocity;

        private float _velocity;

        public void Init(float value)
        {
            Current = value;
            Target = value;
        }

        public void Init(float current, float target)
        {
            Current = current;
            Target = target;
        }

        public float Update(float target)
        {
            Target = target;
            Current = Mathf.SmoothDamp(Current, Target, ref _velocity, SmoothTime);
            return Current;
        }

        public float Update()
        {
            Current = Mathf.SmoothDamp(Current, Target, ref _velocity, SmoothTime);
            return Current;
        }
    }
}
