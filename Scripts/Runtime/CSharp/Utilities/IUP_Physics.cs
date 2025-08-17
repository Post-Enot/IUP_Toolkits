using System;
using UnityEngine;

namespace IUP.Toolkits
{
    public static class IUP_Physics
    {
        public const int AllLayers = -1;
        public const int DefaultRaycastLayers = -5;

        public static Span<Collider> OverlapSphereNonAlloc(
            Vector3 position,
            float radius,
            Collider[] colliders,
            int layerMask = AllLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            int count = Physics.OverlapSphereNonAlloc(
                position,
                radius,
                colliders,
                layerMask,
                queryTriggerInteraction);
            return colliders.AsSpan(0, count);
        }

        public static Span<Collider> OverlapBoxNonAlloc(
            Vector3 center,
            Vector3 halfExtents,
            Collider[] colliders,
            int layerMask = AllLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            int count = Physics.OverlapBoxNonAlloc(
                center,
                halfExtents,
                colliders,
                Quaternion.identity,
                layerMask,
                queryTriggerInteraction);
            return colliders.AsSpan(0, count);
        }


        public static Span<Collider> OverlapBoxNonAlloc(
            Vector3 center,
            Vector3 halfExtents,
            Collider[] colliders,
            Quaternion orientation,
            int layerMask = AllLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            int count = Physics.OverlapBoxNonAlloc(
                center,
                halfExtents,
                colliders,
                orientation,
                layerMask,
                queryTriggerInteraction);
            return colliders.AsSpan(0, count);
        }

        public static Span<Collider> OverlapCapsuleNonAlloc(
            Vector3 point0,
            Vector3 point1,
            float radius,
            Collider[] colliders,
            int layerMask = AllLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            int count = Physics.OverlapCapsuleNonAlloc(
                point0,
                point1,
                radius,
                colliders,
                layerMask,
                queryTriggerInteraction);
            return colliders.AsSpan(0, count);
        }

        public static Span<RaycastHit> RaycastNonAlloc(
            Ray ray,
            RaycastHit[] results,
            float maxDistance = float.PositiveInfinity,
            int layerMask = DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            int count = Physics.RaycastNonAlloc(
                ray,
                results,
                maxDistance,
                layerMask,
                queryTriggerInteraction);
            return results.AsSpan(0, count);
        }

        public static Span<RaycastHit> RaycastNonAlloc(
            Vector3 origin,
            Vector3 direction,
            RaycastHit[] results,
            float maxDistance = float.PositiveInfinity,
            int layerMask = DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            int count = Physics.RaycastNonAlloc(
                origin,
                direction,
                results,
                maxDistance,
                layerMask,
                queryTriggerInteraction);
            return results.AsSpan(0, count);
        }
    }
}
