using System.Collections.Generic;

namespace IUP.Toolkits
{
    public static class ExtensionISet
    {
        public static bool IsEmpty<T>(this ISet<T> self) => self.Count == 0;

        public static bool IsNonEmpty<T>(this ISet<T> self) => self.Count != 0;
    }
}
