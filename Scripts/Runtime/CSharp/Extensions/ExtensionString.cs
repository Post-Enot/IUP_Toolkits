namespace IUP.Toolkits
{
    public static class ExtensionString
    {
        public static bool IsEmpty(this string self) => self.Length == 0;

        public static bool IsNonEmpty(this string self) => self.Length != 0;
    }
}
