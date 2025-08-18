namespace IUP.Toolkits
{
    public static class ExtensionOddEven
    {
        public static bool IsOdd(this byte self) => (self & 1) == 1;

        public static bool IsOdd(this sbyte self) => (self & 1) == 1;

        public static bool IsOdd(this short self) => (self & 1) == 1;

        public static bool IsOdd(this ushort self) => (self & 1) == 1;

        public static bool IsOdd(this int self) => (self & 1) == 1;

        public static bool IsOdd(this uint self) => (self & 1) == 1;

        public static bool IsOdd(this long self) => (self & 1) == 1;

        public static bool IsOdd(this ulong self) => (self & 1) == 1;

        public static bool IsEven(this byte self) => (self & 1) == 0;

        public static bool IsEven(this sbyte self) => (self & 1) == 0;

        public static bool IsEven(this short self) => (self & 1) == 0;

        public static bool IsEven(this ushort self) => (self & 1) == 0;

        public static bool IsEven(this int self) => (self & 1) == 0;

        public static bool IsEven(this uint self) => (self & 1) == 0;

        public static bool IsEven(this long self) => (self & 1) == 0;

        public static bool IsEven(this ulong self) => (self & 1) == 0;
    }
}
