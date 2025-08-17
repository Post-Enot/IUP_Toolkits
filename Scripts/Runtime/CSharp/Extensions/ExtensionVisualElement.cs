using UnityEngine.UIElements;

namespace IUP.Toolkits
{
    public static class ExtensionVisualElement
    {
        public static void SetVisibility(this VisualElement self, bool isVisible)
        {
            if (isVisible)
            {
                self.Show();
            }
            else
            {
                self.Hide();
            }
        }

        public static bool IsShown(this VisualElement self)
            => self.style.display == DisplayStyle.Flex;

        public static bool IsHidden(this VisualElement self)
            => self.style.display == DisplayStyle.None;

        public static void Show(this VisualElement self) => self.style.display = DisplayStyle.Flex;

        public static void Hide(this VisualElement self) => self.style.display = DisplayStyle.None;

        public static void Enable(this VisualElement self) => self.SetEnabled(true);

        public static void Disable(this VisualElement self) => self.SetEnabled(false);

        public static void AddToClassList(this VisualElement self, params string[] classNames)
        {
            foreach (string className in classNames)
            {
                self.AddToClassList(className);
            }
        }

        public static void RemoveFromClassList(this VisualElement self, params string[] classNames)
        {
            foreach (string className in classNames)
            {
                self.RemoveFromClassList(className);
            }
        }
    }
}
