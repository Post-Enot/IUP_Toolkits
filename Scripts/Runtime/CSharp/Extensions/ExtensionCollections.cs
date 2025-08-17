using System;
using System.Collections;

namespace IUP.Toolkits
{
    public static class ExtensionCollections
    {
        public static int LastIndex(this ICollection self) => self.Count - 1;

        public static bool IsEmpty(this ICollection self) => self.Count == 0;

        public static bool IsNonEmpty(this ICollection self) => self.Count != 0;

        public static bool IsEmpty<T>(this ReadOnlySpan<T> self) => self.Length == 0;

        public static bool IsNonEmpty<T>(this ReadOnlySpan<T> self) => self.Length != 0;

        public static bool IsEmpty<T>(this Span<T> self) => self.Length == 0;

        public static bool IsNonEmpty<T>(this Span<T> self) => self.Length != 0;
    }
}
