using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits
{
    [Serializable]
    public sealed class EventBroker : IEventRegistrar, IEventInvoker
    {
        public EventBroker() {}

        public EventBroker(IEventBus eventBus) => _eventBus = eventBus;

        [SerializeField] private EventBusReference _eventBusReference;

        public bool IsEnabled { get; private set; }
        public bool IsDisabled => !IsEnabled;

        private IEventBus EventBus => _eventBus ?? _eventBusReference.EventBus;

        private readonly IEventBus _eventBus;
        private readonly List<TypeCallbackPair> _callbacks = new();

        public IEventRegistrar Enable()
        {
            if (IsDisabled)
            {
                IsEnabled = true;
                foreach (TypeCallbackPair pair in _callbacks)
                {
                    EventBus.RegisterUnsafe(pair.Type, pair.Callback);
                }
            }
            return this;
        }

        public IEventRegistrar Disable()
        {
            if (IsEnabled)
            {
                IsEnabled = false;
                foreach (TypeCallbackPair pair in _callbacks)
                {
                    EventBus.UnregisterWithoutRemovingList(pair.Type, pair.Callback);
                }
            }
            return this;
        }

        public IEventRegistrar SetEnabled(bool isEnabled) => isEnabled ? Enable() : Disable();

        public IEventRegistrar ToggleEnabled() => IsEnabled ? Disable() : Enable();

        public IEventRegistrar Register<TEvent>(EventCallback<TEvent> callback)
        {
            Type eventType = typeof(TEvent);
            TypeCallbackPair pair = new(eventType, callback);
            _callbacks.Add(pair);
            if (IsEnabled)
            {
                EventBus.Register(callback);
            }
            return this;
        }

        public IEventRegistrar Register<TEvent>(EventCallback callback)
        {
            Type eventType = typeof(TEvent);
            TypeCallbackPair pair = new(eventType, callback);
            _callbacks.Add(pair);
            if (IsEnabled)
            {
                EventBus.Register<TEvent>(callback);
            }
            return this;
        }

        public IEventRegistrar Unregister<TEvent>(EventCallback<TEvent> callback)
        {
            Type eventType = typeof(TEvent);
            TypeCallbackPair pair = new(eventType, callback);
            bool isRemove = _callbacks.Remove(pair);
            if (isRemove && IsEnabled)
            {
                _ = EventBus.Unregister(callback);
            }
            return this;
        }

        public IEventRegistrar Unregister<TEvent>(EventCallback callback)
        {
            Type eventType = typeof(TEvent);
            TypeCallbackPair pair = new(eventType, callback);
            bool isRemove = _callbacks.Remove(pair);
            if (isRemove && IsEnabled)
            {
                _ = EventBus.Unregister<TEvent>(callback);
            }
            return this;
        }

        public IEventRegistrar UnregisterAll()
        {
            foreach (TypeCallbackPair pair in _callbacks)
            {
                _ = EventBus.UnregisterUnsafe(pair.Type, pair.Callback);
            }
            _callbacks.Clear();
            return this;
        }

        public void Invoke<TEvent>() where TEvent : new() => EventBus.Invoke<TEvent>();

        public void Invoke<TEvent>(TEvent context) => EventBus.Invoke(context);
    }
}
