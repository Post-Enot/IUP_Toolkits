using UnityEngine;

namespace IUP.Toolkits
{
    public static class MovementUtility
    {
        public static Vector2 InputToMovement(
            Vector2 input,
            Transform transform,
            float factor,
            float speed)
        {
            Vector2 direction = InputToDirection(input, transform);
            return ApplyBackwardMovementFactor(direction, transform.forward.xz(), factor, speed);
        }

        public static Vector2 ApplyBackwardMovementFactor(
            Vector2 movementDirection,
            Vector2 forward,
            float factor,
            float speed)
        {
            float dot = Vector2.Dot(forward, movementDirection);
            dot = (dot + 1) / 2;
            float mult = 1 - dot;
            speed -= speed * mult * factor;
            return movementDirection * speed;
        }

        public static Vector2 InputToDirection(Vector2 input, Transform transform)
        {
            Vector3 input3 = input.x_y();
            Vector3 direction3 = transform.TransformDirection(input3);
            return direction3.xz();
        }
    }
}
