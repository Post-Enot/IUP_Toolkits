using UnityEngine.UIElements;

namespace IUP.Toolkits
{
    public static class ExtensionNavigationDirection
    {
        public static bool IsUp(this NavigationMoveEvent.Direction direction)
            => direction == NavigationMoveEvent.Direction.Up;

        public static bool IsDown(this NavigationMoveEvent.Direction direction)
            => direction == NavigationMoveEvent.Direction.Down;

        public static bool IsLeft(this NavigationMoveEvent.Direction direction)
            => direction == NavigationMoveEvent.Direction.Left;

        public static bool IsRight(this NavigationMoveEvent.Direction direction)
            => direction == NavigationMoveEvent.Direction.Right;

        public static bool IsNext(this NavigationMoveEvent.Direction direction)
            => direction == NavigationMoveEvent.Direction.Next;

        public static bool IsPrevious(this NavigationMoveEvent.Direction direction)
            => direction == NavigationMoveEvent.Direction.Previous;
    }
}
