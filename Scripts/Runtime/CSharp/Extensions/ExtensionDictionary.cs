using System.Collections.Generic;

namespace IUP.Toolkits
{
    public static class ExtensionDictionary
    {
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
