using System;
using UnityEngine;

namespace IUP.Toolkits
{
    /// <summary>
    /// Представляет неизменяемый временной интервал с момента его начала.
    /// Предоставляет методы для расчёта прошедшего и оставшегося времени.
    /// </summary>
    [Serializable]
    public struct TimeRange
    {
        /// <summary>
        /// Инициализирует временной интервал, используя <see cref="Time.time"/> в
        /// качестве момента начала.
        /// </summary>
        /// <param name="duration">Длительность временного интервала в секундах.</param>
        public TimeRange(float duration)
        {
            StartTime = Time.time;
            Duration = duration;
        }

        /// <summary>
        /// Инициализирует временной интервал с указанным временем начала.
        /// </summary>
        /// <param name="duration">Длительность временного интервала в секундах.</param>
        /// <param name="startTime">Метка времени начала в секундах.</param>
        public TimeRange(float duration, float startTime)
        {
            StartTime = startTime;
            Duration = duration;
        }

        /// <summary>
        /// Метка времени начала интервала в секундах.
        /// </summary>
        public float StartTime { get; private set; }

        /// <summary>
        /// Длительность интервала в секундах.
        /// </summary>
        [field: SerializeField][field: Min(0.0f)] public float Duration { get; private set; }

        #region Unclamped

        public readonly float ElapsedUnclamped(float time) => time - StartTime;

        public readonly float ElapsedNormalizedUnclamped(float time)
            => ElapsedUnclamped(time) / Duration;

        public readonly float RemainingUnclamped(float time) => Duration - ElapsedUnclamped(time);

        public readonly float RemainingNormalizedUnclamped(float time)
            => RemainingUnclamped(time) / Duration;

        public readonly float ElapsedUnclamped() => ElapsedUnclamped(Time.time);

        public readonly float ElapsedNormalizedUnclamped()
            => ElapsedNormalizedUnclamped(Time.time);

        public readonly float RemainingUnclamped() => RemainingUnclamped(Time.time);

        public readonly float RemainingNormalizedUnclamped()
            => RemainingNormalizedUnclamped(Time.time);

        #endregion

        #region Clamped

        public readonly float Elapsed(float time)
        {
            float elapsed = ElapsedUnclamped(time);
            return IUP_Math.Clamp0(elapsed, Duration);
        }

        public readonly float ElapsedNormalized(float time)
        {
            float elapsedNormalized = ElapsedNormalizedUnclamped(time);
            return IUP_Math.Clamp01(elapsedNormalized);
        }

        public readonly float Remaining(float time)
        {
            float remaining = RemainingUnclamped(time);
            return IUP_Math.Clamp0(remaining, Duration);
        }

        public readonly float RemainingNormalized(float time)
        {
            float remainingNormalized = RemainingNormalizedUnclamped(time);
            return IUP_Math.Clamp01(remainingNormalized);
        }

        public readonly float Elapsed() => Elapsed(Time.time);

        public readonly float ElapsedNormalized() => ElapsedNormalized(Time.time);

        public readonly float Remaining() => Remaining(Time.time);

        public readonly float RemainingNormalized() => RemainingNormalized(Time.time);

        #endregion

        public readonly bool IsComplete() => IsComplete(Time.time);

        public readonly bool IsComplete(float time) => ElapsedUnclamped(time) >= Duration;

        public readonly bool IsNotComplete() => IsNotComplete(Time.time);

        public readonly bool IsNotComplete(float time) => ElapsedUnclamped(time) < Duration;

        public void Reverse(float time) => StartTime = time - Remaining(time);

        public void Reverse() => Reverse(Time.time);

        public void ReverseUnclamped(float time) => StartTime = time - RemainingUnclamped(time);

        public void ReverseUnclamped() => ReverseUnclamped(Time.time);

        public void Complete(float time) => StartTime = time - Duration;

        public void Complete() => Complete(Time.time);

        public readonly TimeRange WithCompleted(float time)
        {
            float startTime = time - Duration;
            return new TimeRange(Duration, startTime);
        }

        public readonly TimeRange WithCompleted() => WithCompleted(Time.time);

        public readonly TimeRange WithDuration(float duration) => new(duration, StartTime);

        public readonly TimeRange WithStartTime(float startTime) => new(Duration, startTime);

        public readonly TimeRange WithRemaining(float remaining)
            => WithRemaining(remaining, Time.time);

        public readonly TimeRange WithRemaining(float remaining, float time)
        {
            float startTime = time - (Duration + remaining);
            return new TimeRange(Duration, startTime);
        }

        public static TimeRange FromDuration(float duration) => new(duration);

        public static TimeRange FromDuration(float duration, float startTime)
            => new(duration, startTime);

        public static TimeRange Completed(float duration)
        {
            float startTime = Time.time - duration;
            return new(duration, startTime);
        }
    }
}
