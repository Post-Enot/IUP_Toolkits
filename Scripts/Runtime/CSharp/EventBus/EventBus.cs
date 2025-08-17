using System;
using System.Collections.Generic;

namespace IUP.Toolkits
{
    public class EventBus : IEventBus
    {
        private readonly Dictionary<Type, EventList> _eventLists = new();

        public void Register<TEvent>(EventCallback<TEvent> callback)
        {
            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }
            Type eventType = typeof(TEvent);
            AddCallback(eventType, callback);
        }

        public void Register<TEvent>(EventCallback callback)
        {
            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }
            Type eventType = typeof(TEvent);
            AddCallback(eventType, callback);
        }

        public void Register(Type eventType, Delegate callback)
        {
            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }

            AddCallback(eventType, callback);
        }

        public bool Unregister<TEvent>(EventCallback<TEvent> callback)
        {
            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }
            Type eventType = typeof(TEvent);
            return RemoveCallback(eventType, callback);
        }

        public bool Unregister<TEvent>(EventCallback callback)
        {
            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }
            Type eventType = typeof(TEvent);
            return RemoveCallback(eventType, callback);
        }

        public bool UnregisterWithoutRemovingList(Type eventType, Delegate callback)
        {
            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }
            return RemoveCallbackWitthoutRemovingList(eventType, callback);
        }

        public void Invoke<TEvent>() where TEvent : new()
        {
            TEvent context = new();
            Invoke(context);
        }

        public void Invoke<TEvent>(TEvent context)
        {
            Type eventType = typeof(TEvent);
            if (_eventLists.TryGetValue(eventType, out EventList eventList))
            {
                eventList.Invoke(context);
            }
        }

        public bool UnregisterUnsafe(Type eventType, Delegate callback)
        {
            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }
            return RemoveCallback(eventType, callback);
        }

        public void RegisterUnsafe(Type eventType, Delegate callback)
        {
            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }
            AddCallback(eventType, callback);
        }

        private bool RemoveCallbackWitthoutRemovingList(Type eventType, Delegate callback)
        {
            if (_eventLists.TryGetValue(eventType, out EventList eventList))
            {
                return eventList.Remove(callback);
            }
            return false;
        }

        private bool RemoveCallback(Type eventType, Delegate callback)
        {
            if (_eventLists.TryGetValue(eventType, out EventList eventList))
            {
                bool result = eventList.Remove(callback);
                if (_eventLists.IsEmpty())
                {
                    _ = _eventLists.Remove(eventType);
                }
                return result;
            }
            return false;
        }

        private void AddCallback(Type eventType, Delegate callback)
        {
            if (_eventLists.TryGetValue(eventType, out EventList eventList))
            {
                eventList.Add(callback);
            }
            else
            {
                eventList = new EventList();
                eventList.Add(callback);
                _eventLists.Add(eventType, eventList);
            }
        }
    }
}
