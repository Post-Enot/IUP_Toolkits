namespace IUP.Toolkits
{
    public interface IEventInvoker
    {
        public void Invoke<TEvent>() where TEvent : new();

        public void Invoke<TEvent>(TEvent context);
    }
}
