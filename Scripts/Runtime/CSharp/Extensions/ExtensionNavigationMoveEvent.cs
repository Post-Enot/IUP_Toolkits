using UnityEngine.UIElements;

namespace IUP.Toolkits
{
    public static class ExtensionNavigationMoveEvent
    {
        public static bool IsUp(this NavigationMoveEvent context)
            => context.direction == NavigationMoveEvent.Direction.Up;

        public static bool IsDown(this NavigationMoveEvent context)
            => context.direction == NavigationMoveEvent.Direction.Down;

        public static bool IsLeft(this NavigationMoveEvent context)
            => context.direction == NavigationMoveEvent.Direction.Left;

        public static bool IsRight(this NavigationMoveEvent context)
            => context.direction == NavigationMoveEvent.Direction.Right;

        public static bool IsNext(this NavigationMoveEvent context)
            => context.direction == NavigationMoveEvent.Direction.Next;

        public static bool IsPrevious(this NavigationMoveEvent context)
            => context.direction == NavigationMoveEvent.Direction.Previous;
    }
}
