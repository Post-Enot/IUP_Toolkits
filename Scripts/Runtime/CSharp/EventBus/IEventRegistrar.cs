namespace IUP.Toolkits
{
    public interface IEventRegistrar
    {
        public bool IsEnabled { get; }
        public bool IsDisabled { get; }

        public IEventRegistrar Enable();

        public IEventRegistrar Disable();

        public IEventRegistrar SetEnabled(bool isEnabled);

        public IEventRegistrar ToggleEnabled();

        public IEventRegistrar Register<TEvent>(EventCallback<TEvent> callback);

        public IEventRegistrar Register<TEvent>(EventCallback callback);

        public IEventRegistrar Unregister<TEvent>(EventCallback<TEvent> callback);

        public IEventRegistrar Unregister<TEvent>(EventCallback callback);

        public IEventRegistrar UnregisterAll();
    }
}
