using System;
using UnityEngine;

namespace IUP.Toolkits
{
    [Serializable]
    public sealed class FloatSpringDamp
    {
        [field: SerializeField] public float Current { get; set; }
        [field: SerializeField] public float Target { get; set; }
        [field: SerializeField] public float Frequency { get; set; } = 10.0f;
        [field: SerializeField] public float Damping { get; set; } = 0.25f;

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
            Current = IUP_Math.HarmonicDamp(Current, ref _velocity, Target, Frequency, Damping, Time.deltaTime);
            return Current;
        }

        public float Update()
        {
            Current = IUP_Math.HarmonicDamp(Current, ref _velocity, Target, Frequency, Damping, Time.deltaTime);
            return Current;
        }
    }
}
