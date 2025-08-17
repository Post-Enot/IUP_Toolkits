using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits
{
    public sealed class EventList
    {
        private static readonly Predicate<object> _isNull = obj => obj == null;

        private readonly List<Delegate> _callbacks = new();

        private int _activeInvokeCount;
        private bool _defferedNullClearing;

        public bool IsEmpty() => _callbacks.Count == 0;

        public void Add(Delegate callback) => _callbacks.Add(callback);

        public bool Remove(Delegate callback)
        {
            if (_activeInvokeCount == 0)
            {
                return _callbacks.Remove(callback);
            }
            int index = _callbacks.IndexOf(callback);
            if (index == -1)
            {
                return false;
            }
            _callbacks[index] = null;
            _defferedNullClearing = true;
            return true;
        }

        public void Invoke<TEvent>(TEvent context)
        {
            _activeInvokeCount += 1;
            for (int i = 0; i < _callbacks.Count; i += 1)
            {
                Delegate specificCallback = _callbacks[i];
                if (specificCallback == null)
                {
                    continue;
                }
                try
                {
                    if (specificCallback is EventCallback<TEvent> callbackWithContext)
                    {
                        callbackWithContext.Invoke(context);
                    }
                    else
                    {
                        EventCallback callback = (EventCallback)specificCallback;
                        callback.Invoke();
                    }
                }
                catch (Exception exception)
                {
                    Debug.LogException(exception);
                }
            }
            if ((_activeInvokeCount == 1) && _defferedNullClearing)
            {
                _ = _callbacks.RemoveAll(_isNull);
                _defferedNullClearing = false;
            }
            _activeInvokeCount -= 1;
        }
    }
}
