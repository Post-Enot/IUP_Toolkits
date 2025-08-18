using System;

namespace IUP.Toolkits
{
    public sealed class SystemRandomGenerator : IRandomGenerator
    {
        public SystemRandomGenerator() => _random = new Random();

        public SystemRandomGenerator(int seed) => _random = new Random(seed);

        public SystemRandomGenerator(Random random) => _random = random;

        private readonly Random _random;

        public int Int() => _random.Next();

        public int Int(int maxExclusive)
            => _random.Next(maxExclusive);

        public int Int(int minInclusive, int maxExclusive)
            => _random.Next(minInclusive, maxExclusive);
    }
}
