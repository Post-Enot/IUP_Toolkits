using UnityEngine;

namespace IUP.Toolkits
{
    [CreateAssetMenu(
        fileName = "Event Bus Reference",
        menuName = "IUP/Toolkits/Event Bus Reference")]
    public sealed class EventBusReference : ScriptableObject
    {
        public IEventBus EventBus
        {
            get
            {
                _eventBus ??= new EventBus();
                return _eventBus;
            }
        }

        private EventBus _eventBus;
    }
}
