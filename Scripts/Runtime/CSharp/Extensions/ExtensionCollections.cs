using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IUP.Toolkits
{
    public static class ExtensionCollections
    {
        #region IsEmpty

        public static bool IsEmpty(this ICollection self) => self.Count == 0;

        public static bool IsEmpty<T>(this ISet<T> self) => self.Count == 0;

        public static bool IsEmpty<T>(this ReadOnlySpan<T> self) => self.Length == 0;

        public static bool IsEmpty<T>(this Span<T> self) => self.Length == 0;

        public static bool IsEmpty(this string self) => self.Length == 0;
        #endregion

        #region IsNonEmpty
        public static bool IsNonEmpty(this ICollection self) => self.Count != 0;

        public static bool IsNonEmpty<T>(this ISet<T> self) => self.Count != 0;

        public static bool IsNonEmpty<T>(this ReadOnlySpan<T> self) => self.Length != 0;

        public static bool IsNonEmpty<T>(this Span<T> self) => self.Length != 0;

        public static bool IsNonEmpty(this string self) => self.Length != 0;
        #endregion

        public static int LastIndex(this ICollection self) => self.Count - 1;

        public static void Recreate<T>(this List<T> self, int size)
        {
            self.Clear();
            IEnumerable<T> range = Enumerable.Repeat(default(T), size);
            self.AddRange(range);
        }

        public static bool TryChangeKey<TKey, TValue>(
            this Dictionary<TKey, TValue> self,
            TKey oldKey,
            TKey newKey)
        {
            if (!self.ContainsKey(newKey) && self.Remove(oldKey, out TValue value))
            {
                self.Add(newKey, value);
                return true;
            }
            return false;
        }

        public static void ChangeKey<TKey, TValue>(
            this Dictionary<TKey, TValue> self,
            TKey oldKey,
            TKey newKey)
        {
            TValue value = self[oldKey];
            _ = self.Remove(oldKey);
            self.Add(newKey, value);
        }
    }
}
