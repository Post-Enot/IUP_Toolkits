using UnityEngine;

namespace IUP.Toolkits
{
    public static class RaycastUtility
    {
        public static bool CastCenter(
            out RaycastHit hit,
            Camera camera,
            LayerMask layerMask,
            float maxDistance = float.PositiveInfinity)
        {
            Vector3 center = new(0.5f, 0.5f);
            Ray ray = camera.ViewportPointToRay(center);
            return Physics.Raycast(ray, out hit, maxDistance, layerMask);
        }

        public static bool CastCenterCollider(
            out RaycastHit hit,
            Camera camera,
            LayerMask layerMask,
            float maxDistance = float.PositiveInfinity)
        {
            Vector3 center = new(0.5f, 0.5f);
            Ray ray = camera.ViewportPointToRay(center);
            maxDistance = GetRayLength(ray.direction, maxDistance);
            return Physics.Raycast(ray, out hit, maxDistance, layerMask);
        }

        public static float GetRayLength(Vector3 direction, float radius)
        {
            float dx = direction.x;
            float dy = direction.y;
            float dz = direction.z;

            bool isParallelToY = ((dx * dx) + (dz * dz)) < 0.0001f;

            float L_side = isParallelToY
                ? float.PositiveInfinity
                : radius / Mathf.Sqrt(dx * dx + dz * dz);

            // Пересечение с верхней/нижней крышкой
            float L_top = (dy > 0) ? (radius / dy) : float.PositiveInfinity;
            float L_bottom = (dy < 0) ? (-radius / dy) : float.PositiveInfinity;

            // Выбираем минимальное расстояние
            return Mathf.Min(L_side, L_top, L_bottom);
        }

        public static bool TryCastComponentCenterCylinder<TComponent>(
            out TComponent component,
            Camera camera,
            LayerMask layerMask,
            float maxDistance = float.PositiveInfinity) where TComponent : Component
        {
            Vector3 center = new(0.5f, 0.5f);
            Ray ray = camera.ViewportPointToRay(center);
            maxDistance = GetRayLength(ray.direction, maxDistance);
            return TryCastComponent(out component, ray, layerMask, maxDistance);
        }

        public static bool TryCastComponentCenter<TComponent>(
            out TComponent component,
            Camera camera,
            LayerMask layerMask,
            float maxDistance = float.PositiveInfinity) where TComponent : Component
        {
            Vector3 center = new(0.5f, 0.5f);
            Ray ray = camera.ViewportPointToRay(center);
            return TryCastComponent(out component, ray, layerMask, maxDistance);
        }

        public static bool TryCastComponent<TComponent>(
            out TComponent component,
            Ray ray,
            LayerMask layerMask,
            float maxDistance = float.PositiveInfinity) where TComponent : Component
        {
            if (Physics.Raycast(ray, out RaycastHit hit, maxDistance, layerMask))
            {
                return ((hit.rigidbody != null) && hit.rigidbody.TryGetComponent(out component))
                    || hit.collider.TryGetComponent(out component);
            }
            component = null;
            return false;
        }
    }
}
