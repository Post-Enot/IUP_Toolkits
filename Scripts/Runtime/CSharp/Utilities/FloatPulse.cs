using System;
using UnityEngine;

namespace IUP.Toolkits
{
    [Serializable]
    public sealed class FloatPulse
    {
        [field: Min(0)][field: SerializeField] public float PeriodSeconds { get; set; } = 1.0f;
        [field: Min(0)][field: SerializeField] public float AmplitudeNormalized { get; set; }
            = 0.5f;

        public float Original { get; set; }
        public float Phase { get; set; }

        public float Update()
        {
            Phase += Time.deltaTime / PeriodSeconds * IUP_Math.PI2;
            Phase -= (int)(Phase * IUP_Math.PI2Inverse) * IUP_Math.PI2;
            float scale = 1.0f + IUP_Math.FastSin(Phase) * AmplitudeNormalized;
            return Original * scale;
        }
    }
}
