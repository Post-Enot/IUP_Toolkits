namespace IUP.Toolkits
{
    public static class TimerUtility
    {
        public static UnityTimeProvider UnityTimeProvider
        {
            get
            {
                _unityTimeProvider ??= new UnityTimeProvider();
                return _unityTimeProvider;
            }
        }

        private static UnityTimeProvider _unityTimeProvider;

        public static Timer CreateUnityTimer(float duration = 0.0f)
            => new(UnityTimeProvider, duration);
    }
}
