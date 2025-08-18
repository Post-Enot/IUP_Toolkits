using System;
using System.Collections.Generic;

namespace IUP.Toolkits
{
    public static class IUP_Random
    {
        public static IRandomGenerator UnityRandomGenerator
        {
            get
            {
                _unityRandomGenerator ??= new UnityRandomGenerator();
                return _unityRandomGenerator;
            }
        }

        private static UnityRandomGenerator _unityRandomGenerator;

        public static void Shuffle<T>(Span<T> collection)
            => Shuffle(collection, UnityRandomGenerator);

        public static void Shuffle<T>(Span<T> collection, IRandomGenerator random)
        {
            for (int i = collection.Length - 1; i >= 1; i -= 1)
            {
                int j = random.Int(i + 1);
                (collection[i], collection[j]) = (collection[j], collection[i]);
            }
        }

        public static void Shuffle<T>(IList<T> collection) => Shuffle(collection, UnityRandomGenerator);

        public static void Shuffle<T>(IList<T> collection, IRandomGenerator random)
        {
            for (int i = collection.Count - 1; i >= 1; i -= 1)
            {
                int j = random.Int(i + 1);
                (collection[i], collection[j]) = (collection[j], collection[i]);
            }
        }
    }
}
