using System;
using UnityEngine;

namespace IUP.Toolkits
{
    [Serializable]
    public sealed class EventInvoker : IEventInvoker
    {
        public EventInvoker() {}

        public EventInvoker(IEventBus eventBus) => _eventBus = eventBus;

        [SerializeField] private EventBusReference _eventBusReference;

        private IEventBus EventBus => _eventBus ?? _eventBusReference.EventBus;

        private readonly IEventBus _eventBus;

        public void Invoke<TEvent>() where TEvent : new() => EventBus.Invoke<TEvent>();

        public void Invoke<TEvent>(TEvent context) => EventBus.Invoke(context);
    }
}
