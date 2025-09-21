using System;

namespace IUP.Toolkits
{
    /// <summary>
    /// Представляет метку времени с фиксированной длительностью, предоставляющую методы для
    /// расчёта прошедшего и оставшегося времени.
    /// </summary>
    public readonly struct TimeStamp
    {
        internal TimeStamp(float startTime, float currentTime, float duration)
        {
            StartTime = startTime;
            CurrentTime = currentTime;
            Duration = duration;
        }

        /// <summary>
        /// Время начала отсчёта в секундах.
        /// </summary>
        public readonly float StartTime { get; }
        /// <summary>
        /// Текущее время отсчёта в секундах.
        /// </summary>
        public readonly float CurrentTime { get; }
        /// <summary>
        /// Общая длительность временного интервала в секундах.
        /// </summary>
        public readonly float Duration { get; }

        /// <summary>
        /// Возвращает прошедшее с начата отсчёта время в секундах, ограниченное диапазоном
        /// [0, <see cref="Duration"/>].
        /// </summary>
        /// <returns>
        /// Прошедшее с начала отсчёта время в секундах, ограниченное диапазоном
        /// [0, <see cref="Duration"/>].
        /// </returns>
        public readonly float Elapsed()
        {
            float elapsedUnclamped = CurrentTime - StartTime;
            return IUP_Math.Min(elapsedUnclamped, Duration);
        }

        /// <summary>
        /// Возвращает нормализованное прошедшее с начала отсчёта время, ограниченное диапазоном 
        /// [0, 1].
        /// </summary>
        /// <returns>
        /// <see cref="float.NaN"/>, если длительность равна 0; иначе нормализованное прошедшее с 
        /// начала отсчёта время, ограниченное диапазоном [0, 1].
        /// </returns>
        public readonly float ElapsedNormalized() => Elapsed() / Duration;

        /// <summary>
        /// Возвращает нормализованное прошедшее с начала отсчёта время, ограниченное диапазоном
        /// [0, 1] с обработкой нулевой длительности.
        /// </summary>
        /// <param name="zeroDurationReturn">
        /// Значение, возвращаемое при нулевой длительности.
        /// </param>
        /// <returns>
        /// <paramref name="zeroDurationReturn"/>, если длительность равна 0; иначе нормализованное 
        /// прошедшее с начала отсчёта время в диапазоне [0, 1].
        /// </returns>
        public readonly float ElapsedNormalized(float zeroDurationReturn)
        {
            float elapsed = Elapsed();
            return CalculateRatio(elapsed, zeroDurationReturn);
        }

        /// <summary>
        /// Возвращает время, оставшееся до завершения интервала в секундах, ограниченное диапазоном
        /// [0, <see cref="Duration"/>].
        /// </summary>
        /// <returns>
        /// Время, оставшееся до завершения интервала в диапазоне [0, <see cref="Duration"/>].
        /// </returns>
        public readonly float Remaining() => Duration - Elapsed();

        /// <summary>
        /// Возвращает нормализированное время, оставшееся до завершения интервала, ограниченное
        /// диапазоном [0, 1].
        /// </summary>
        /// <returns>
        /// <see cref="float.NaN"/>, если длительность равна 0; иначе нормализированное время,
        /// оставшееся до завершения интервала, ограниченное диапазоном [0, 1].
        /// </returns>
        public readonly float RemainingNormalized() => Remaining() / Duration;

        /// <summary>
        /// Возвращает нормализированное время, оставшееся до завершения интервала, ограниченное
        /// диапазоном [0, 1], с обработкой нулевой длительности.
        /// </summary>
        /// <param name="zeroDurationReturn">
        /// Значение, возвращаемое при нулевой длительности.
        /// </param>
        /// <returns>
        /// <see cref="float.NaN"/>, если длительность равна 0; иначе нормализированное время,
        /// оставшееся до завершения интервала, ограниченное диапазоном [0, 1].
        /// </returns>
        public readonly float RemainingNormalized(float zeroDurationReturn)
        {
            float remaining = Remaining();
            return CalculateRatio(remaining, zeroDurationReturn);
        }

        /// <summary>
        /// Возвращает прошедшее с начата отсчёта время в секундах.
        /// </summary>
        /// <returns>
        /// Прошедшее с начала отсчёта время в секундах.
        /// </returns>
        public readonly float ElapsedUnclamped() => CurrentTime - StartTime;

        /// <summary>
        /// Возвращает соотношение прошедшего с начала отсчёта времени к продолжительности в 
        /// секундах.
        /// </summary>
        /// <returns>
        /// <see cref="float.NaN"/>, если длительность равна 0; иначе соотношение прошедшего с 
        /// начала отсчёта времени к продолжительности в секундах.
        /// </returns>
        public readonly float ElapsedRatio() => ElapsedUnclamped() / Duration;

        /// <summary>
        /// Возвращает соотношение прошедшего с начала отсчёта времени к продолжительности в 
        /// секундах с обработкой нулевой длительности.
        /// </summary>
        /// <returns>
        /// <paramref name="zeroDurationReturn"/>, если длительность равна 0; иначе соотношение
        /// прошедшего с начала отсчёта времени к продолжительности в секундах.
        /// </returns>
        public readonly float ElapsedRatio(float zeroDurationReturn)
        {
            float elapsedUnclamped = ElapsedUnclamped();
            return CalculateRatio(elapsedUnclamped, zeroDurationReturn);
        }

        /// <summary>
        /// Возвращает время, оставшееся до завершения интервала в секундах.
        /// </summary>
        /// <returns>
        /// Время, оставшееся до завершения интервала.
        /// </returns>
        public readonly float RemainingUnclamped() => Duration - ElapsedUnclamped();

        /// <summary>
        /// Возвращает соотношение оставшегося до завершения времени к продолжительности в секундах 
        /// с обработкой нулевой длительности.
        /// </summary>
        /// <returns>
        /// <see cref="float.NaN"/>, если длительность равна 0; иначе соотношение
        /// оставшегося до завершения времени к продолжительности в секундах.
        /// </returns>
        public readonly float RemainingRatio() => RemainingUnclamped() / Duration;

        /// <summary>
        /// Возвращает соотношение оставшегося до завершения времени к продолжительности в секундах 
        /// с обработкой нулевой длительности.
        /// </summary>
        /// <returns>
        /// <paramref name="zeroDurationReturn"/>, если длительность равна 0; иначе соотношение
        /// оставшегося до завершения времени к продолжительности в секундах.
        /// </returns>
        public readonly float RemainingRatio(float zeroDurationReturn)
        {
            float remainingUnclamped = RemainingUnclamped();
            return CalculateRatio(remainingUnclamped, zeroDurationReturn);
        }

        /// <summary>
        /// Проверяет, истекло ли время.
        /// </summary>
        /// <returns>
        /// True, если прошедшее с начала отсчёта время превышает длительность; иначе false.
        /// </returns>
        public readonly bool IsCompleted() => ElapsedUnclamped() >= Duration;

        /// <summary>
        /// Проверяет, что время ещё не истекло.
        /// </summary>
        /// <returns>
        /// True, если прошедшее с начала отсчёта время не превышает длительность; иначе false.
        /// </returns>
        public readonly bool IsNotCompleted() => !IsCompleted();

        public readonly TimeStamp Update(float time) => Create(StartTime, time, Duration);

        public readonly TimeStamp UpdateUnsafe(float time) => new(StartTime, time, Duration);

        public readonly TimeStamp Reverse()
        {
            float startTime = CurrentTime - Remaining();
            return new(startTime, CurrentTime, Duration);
        }

        public readonly TimeStamp ReverseUnclamped()
        {
            float startTime = CurrentTime - RemainingUnclamped();
            return new(startTime, CurrentTime, Duration);
        }

        private readonly float CalculateRatio(float time, float zeroDurationReturn)
        {
            if (Duration == 0.0f)
            {
                return zeroDurationReturn;
            }
            return time / Duration;
        }

        public static TimeStamp Create(float startTime, float duration)
        {
            if (duration < 0.0f)
            {
                throw new ArgumentOutOfRangeException(nameof(duration));
            }
            return new TimeStamp(startTime, startTime, duration);
        }

        public static TimeStamp Create(float startTime, float currentTime, float duration)
        {
            if (startTime > currentTime)
            {
                throw new ArgumentOutOfRangeException(nameof(currentTime));
            }
            if (duration < 0.0f)
            {
                throw new ArgumentOutOfRangeException(nameof(duration));
            }
            return new TimeStamp(startTime, currentTime, duration);
        }

        public static TimeStamp CreateUnsafe(float startTime, float currentTime, float duration)
            => new(startTime, currentTime, duration);

        public static TimeStamp CreateUnsafe(float startTime, float duration)
            => new(startTime, startTime, duration);

        public static TimeStamp CreateCompleted(float currentTime, float duration)
        {
            if (duration < 0.0f)
            {
                throw new ArgumentOutOfRangeException(nameof(duration));
            }
            float startTime = currentTime - duration;
            return new TimeStamp(startTime, currentTime, duration);
        }

        public static TimeStamp CreateCompletedUnsafe(float currentTime, float duration)
        {
            float startTime = currentTime - duration;
            return new TimeStamp(startTime, currentTime, duration);
        }
    }
}
