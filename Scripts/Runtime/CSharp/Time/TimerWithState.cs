using System;

namespace IUP.Toolkits
{
    public sealed class TimerWithState
    {
        public TimerWithState(ITimeProvider timeProvider) => _timeProvider = timeProvider;

        public TimerWithState(ITimeProvider timeProvider, float duration = 0.0f)
        {
            _timeProvider = timeProvider;
            float currentTime = _timeProvider.GetCurrentTime();
            Stamp = TimeStamp.CreateCompleted(currentTime, duration);
        }

        public TimerState State { get; private set; }
        public TimeStamp Stamp { get; private set; }

        public bool IsPaused => State == TimerState.Pause;
        public bool IsNotPaused => State != TimerState.Pause;
        public bool IsRun => State == TimerState.Run;
        public bool IsNotRun => State != TimerState.Run;
        public bool IsCompleted => State == TimerState.Complete;
        public bool IsNotCompleted => State != TimerState.Complete;

        private readonly ITimeProvider _timeProvider;

        public void Start(float duration)
        {
            float time = _timeProvider.GetCurrentTime();
            if (duration < 0.0f)
            {
                throw new ArgumentOutOfRangeException(nameof(duration));
            }
            Stamp = TimeStamp.CreateUnsafe(time, time, duration);
            State = TimerState.Run;
        }

        public void Restart() => Start(Stamp.Duration);

        public void Reverse() => Stamp = Stamp.Reverse();

        public void Pause()
        {
            if (State == TimerState.Run)
            {
                State = TimerState.Pause;
            }
        }

        public void Resume()
        {
            if (State == TimerState.Pause)
            {
                State = TimerState.Run;
                float time = _timeProvider.GetCurrentTime();
                float startTime = time - Stamp.ElapsedUnclamped();
                Stamp = TimeStamp.CreateUnsafe(startTime, time, Stamp.Duration);
            }
        }

        public bool Update()
        {
            if (State != TimerState.Run)
            {
                return false;
            }
            float time = _timeProvider.GetCurrentTime();
            Stamp = Stamp.UpdateUnsafe(time);
            if (Stamp.IsCompleted())
            {
                State = TimerState.Complete;
            }
            return true;
        }
    }
}
