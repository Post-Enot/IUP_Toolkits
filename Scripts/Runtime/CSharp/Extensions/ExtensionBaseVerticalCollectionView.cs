using UnityEngine.UIElements;

namespace IUP.Toolkits
{
    public static class ExtensionBaseVerticalCollectionView
    {
        public static bool IsSelected(this BaseVerticalCollectionView collectionView)
            => (collectionView.selectedIndex >= 0) &&
                   (collectionView.itemsSource != null) &&
                   (collectionView.selectedIndex < collectionView.itemsSource.Count);

        public static bool IsLastSelected(this BaseVerticalCollectionView collectionView)
            => (collectionView.itemsSource != null) &&
                   (collectionView.selectedIndex == (collectionView.itemsSource.Count - 1));

        public static bool IsEmpty(this BaseVerticalCollectionView collectionView)
            => (collectionView.itemsSource == null) || (collectionView.itemsSource.Count == 0);

        public static bool IsNonEmpty(this BaseVerticalCollectionView collectionView)
            => (collectionView.itemsSource != null) && (collectionView.itemsSource.Count != 0);

        public static void SelectLast(this BaseVerticalCollectionView collectionView)
        {
            if (collectionView.itemsSource != null)
            {
                int lastIndex = collectionView.itemsSource.Count - 1;
                collectionView.SetSelection(lastIndex);
            }
        }
    }
}
