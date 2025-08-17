using UnityEngine;

namespace IUP.Toolkits
{
    public sealed class DoubleClickHelper
    {
        private float _startTime;
        private float Duration => Time.time - _startTime;
        private bool _isStarted;

        public void Start()
        {
            _isStarted = true;
            _startTime = Time.time;
        }

        public void Abort() => _isStarted = false;

        public bool CanPerform(float maxDuration)
        {
            bool result = _isStarted && (Duration <= maxDuration);
            _isStarted = false;
            return result;
        }
    }
}
