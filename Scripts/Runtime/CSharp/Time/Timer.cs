using System;

namespace IUP.Toolkits
{
    public sealed class Timer
    {
        public Timer(ITimeProvider timeProvider) => _timeProvider = timeProvider;

        public Timer(ITimeProvider timeProvider, float duration = 0.0f)
        {
            _timeProvider = timeProvider;
            float currentTime = _timeProvider.GetCurrentTime();
            Stamp = TimeStamp.CreateCompleted(currentTime, duration);
        }

        public TimeStamp Stamp { get; private set; }
        public bool IsCompleted => Stamp.IsCompleted();
        public bool IsNotCompleted => Stamp.IsNotCompleted();

        private readonly ITimeProvider _timeProvider;

        public void Start(float duration)
        {
            float time = _timeProvider.GetCurrentTime();
            if (duration < 0.0f)
            {
                throw new ArgumentOutOfRangeException(nameof(duration));
            }
            Stamp = TimeStamp.CreateUnsafe(time, time, duration);
        }

        public void Restart() => Start(Stamp.Duration);

        public void Reverse()
        {
            float currentTime = _timeProvider.GetCurrentTime();
            float startTime = currentTime - Stamp.Remaining();
            Stamp = TimeStamp.CreateUnsafe(startTime, currentTime, Stamp.Duration);
        }

        public bool Update()
        {
            if (Stamp.IsCompleted())
            {
                return false;
            }
            float time = _timeProvider.GetCurrentTime();
            Stamp = Stamp.UpdateUnsafe(time);
            return true;
        }
    }
}
