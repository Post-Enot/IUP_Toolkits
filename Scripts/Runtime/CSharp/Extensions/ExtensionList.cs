using System.Collections.Generic;
using System.Linq;

namespace IUP.Toolkits
{
    public static class ExtensionList
    {
        public static void Recreate<T>(this List<T> self, int size)
        {
            self.Clear();
            IEnumerable<T> range = Enumerable.Repeat(default(T), size);
            self.AddRange(range);
        }
    }
}
