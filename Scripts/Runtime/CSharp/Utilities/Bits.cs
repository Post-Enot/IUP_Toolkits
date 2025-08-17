namespace IUP.Toolkits
{
    public static class Bits
    {
        public static bool IsSet(int value, int index) => (value & (1 << index)) != 0;

        public static bool IsSet(uint value, int index) => (value & (1U << index)) != 0U;

        public static bool IsSet(long value, int index) => (value & (1L << index)) != 0L;

        public static bool IsSet(ulong value, int index) => (value & (1UL << index)) != 0UL;

        public static int Set(int value, int index) => value | (1 << index);

        public static uint Set(uint value, int index) => value | (1U << index);

        public static long Set(long value, int index) => value | (1L << index);

        public static ulong Set(ulong value, int index) => value | (1UL << index);

        public static int Set(int value, int index, bool state)
            => state ? Set(value, index) : Unset(value, index);

        public static uint Set(uint value, int index, bool state)
            => state ? Set(value, index) : Unset(value, index);

        public static long Set(long value, int index, bool state)
            => state ? Set(value, index) : Unset(value, index);

        public static ulong Set(ulong value, int index, bool state)
            => state ? Set(value, index) : Unset(value, index);

        public static int Unset(int value, int index) => value & ~(1 << index);

        public static uint Unset(uint value, int index) => value & ~(1U << index);

        public static long Unset(long value, int index) => value & ~(1L << index);

        public static ulong Unset(ulong value, int index) => value & ~(1UL << index);

        public static int Toggle(int value, int index) => value ^ (1 << index);

        public static uint Toggle(uint value, int index) => value ^ (1U << index);

        public static long Toggle(long value, int index) => value ^ (1L << index);

        public static ulong Toggle(ulong value, int index) => value ^ (1UL << index);

        public static bool IsAny(int value, int mask) => (value & mask) != 0;

        public static bool IsAny(uint value, uint mask) => (value & mask) != 0U;

        public static bool IsAny(long value, long mask) => (value & mask) != 0L;

        public static bool IsAny(ulong value, ulong mask) => (value & mask) != 0UL;

        public static bool IsAll(int value, int mask) => (value & mask) == mask;

        public static bool IsAll(uint value, uint mask) => (value & mask) == mask;

        public static bool IsAll(long value, long mask) => (value & mask) == mask;

        public static bool IsAll(ulong value, ulong mask) => (value & mask) == mask;
    }
}
