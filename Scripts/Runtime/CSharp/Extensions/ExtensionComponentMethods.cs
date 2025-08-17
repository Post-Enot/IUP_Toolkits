using UnityEngine;

namespace IUP.Toolkits
{
    public static class ExtensionComponentMethods
    {
        public static bool HasComponent<TComponent>(this GameObject self)
            where TComponent : Component => self.GetComponent<TComponent>() != null;

        public static bool HasComponent<TComponent>(this Component self)
            where TComponent : Component => self.GetComponent<TComponent>() != null;

        public static TComponent GetOrAddComponent<TComponent>(this GameObject self)
            where TComponent : Component
        {
            if (self.TryGetComponent(out TComponent component))
            {
                return component;
            }
            return self.AddComponent<TComponent>();
        }

        public static TComponent GetOrAddComponent<TComponent>(this Component self)
            where TComponent : Component
        {
            if (self.TryGetComponent(out TComponent component))
            {
                return component;
            }
            return self.gameObject.AddComponent<TComponent>();
        }
    }
}
