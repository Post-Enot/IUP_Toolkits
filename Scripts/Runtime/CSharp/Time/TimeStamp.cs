namespace IUP.Toolkits
{
    public readonly struct TimeStamp
    {
        public TimeStamp(float startTime) => StartTime = startTime;

        public readonly float StartTime { get; }
        public readonly float Elapsed => UnityEngine.Time.time - StartTime;

        public static TimeStamp Current => new(UnityEngine.Time.time);

        public readonly bool IsElapsed(float seconds) => Elapsed >= seconds;

        public readonly bool IsNotElapsed(float seconds) => Elapsed < seconds;
    }
}
