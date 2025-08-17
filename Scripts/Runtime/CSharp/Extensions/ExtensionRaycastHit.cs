using UnityEngine;

namespace IUP.Toolkits
{
    public static class ExtensionRaycastHit
    {
        public static bool TryGetComponent<TComponent>(
            this RaycastHit self,
            out TComponent component) where TComponent : Component
        {
            if ((self.rigidbody != null) && self.rigidbody.TryGetComponent(out component))
            {
                return true;
            }
            if ((self.collider != null) && self.collider.TryGetComponent(out component))
            {
                return true;
            }
            component = default;
            return false;
        }
    }
}
