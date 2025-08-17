using System;

namespace IUP.Toolkits
{
    public interface IEventBus
    {
        public void Register<TEvent>(EventCallback<TEvent> callback);

        public void Register<TEvent>(EventCallback callback);

        public bool Unregister<TEvent>(EventCallback<TEvent> callback);

        public bool Unregister<TEvent>(EventCallback callback);

        public void RegisterUnsafe(Type eventType, Delegate callback);

        public bool UnregisterUnsafe(Type eventType, Delegate callback);
        
        public bool UnregisterWithoutRemovingList(Type eventType, Delegate callback);

        public void Invoke<TEvent>() where TEvent : new();

        public void Invoke<TEvent>(TEvent context);
    }
}
