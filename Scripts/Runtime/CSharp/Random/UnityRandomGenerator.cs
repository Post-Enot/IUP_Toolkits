using UnityEngine;

namespace IUP.Toolkits
{
    public class UnityRandomGenerator : IRandomGenerator
    {
        internal UnityRandomGenerator() {}

        public int Int() => Random.Range(0, int.MaxValue);

        public int Int(int maxExclusive) => Random.Range(0, maxExclusive);

        public int Int(int minInclusive, int maxExclusive)
            => Random.Range(minInclusive, maxExclusive);
    }
}
