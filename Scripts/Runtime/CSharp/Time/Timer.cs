using UnityEngine;

namespace IUP.Toolkits
{
    public sealed class Timer
    {
        public float StartTime { get; private set; }
        public float Duration { get; private set; }

        public float Time => UnityEngine.Time.time - StartTime;
        public float TimeClamped => Mathf.Clamp(Time, 0.0f, Duration);

        public float TimeInversed => Duration - Time;
        public float TimeInversedClamped => Duration - TimeClamped;

        public float TimeNormalized => Time / Duration;
        public float TimeNormalizedClamped => TimeClamped / Duration;

        public float TimeNormalizedInversed => 1.0f - TimeNormalized;
        public float TimeNormalizedInversedClamped => 1.0f - TimeNormalizedClamped;

        public bool IsFinished => Time >= Duration;

        public void InitNormalized(float duration, float timeNormalized)
        {
            Duration = duration;
            StartTime = UnityEngine.Time.time - (duration * timeNormalized);
        }

        public void Start(float duration)
        {
            StartTime = UnityEngine.Time.time;
            Duration = duration;
        }

        public void Restart() => StartTime = UnityEngine.Time.time;

        public int SetDurationRemainder()
        {
            int result = (int)(Time / Duration);
            StartTime = UnityEngine.Time.time - (Time % Duration);
            return result;
        }

        public void Inverse() => StartTime = UnityEngine.Time.time - TimeInversedClamped;
    }
}
