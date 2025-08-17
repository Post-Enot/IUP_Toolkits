using System;
using System.Text;

namespace IUP.Toolkits
{
    public static class CodeGeneratorUtility
    {
        public const string Void = "void";

        public static string ToValidID(ReadOnlySpan<char> str, StringBuilder stringBuilder = null)
        {
            if (str.IsEmpty)
            {
                throw new ArgumentException("Input string cannot be empty.", nameof(str));
            }
            static string Other(ReadOnlySpan<char> str, StringBuilder stringBuilder, int start)
            {
                char firstChar = str[start];
                stringBuilder.Append(firstChar);
                start += 1;
                ReadOnlySpan<char> slice = str[start..];
                foreach (char ch in slice)
                {
                    if ((ch == '_') || char.IsLetterOrDigit(ch))
                    {
                        stringBuilder.Append(ch);
                    }
                }
                return stringBuilder.ToString();
            }
            stringBuilder ??= new StringBuilder(str.Length);
            for (int i = 0; i < str.Length; i += 1)
            {
                char ch = str[i];
                if (char.IsDigit(ch))
                {
                    stringBuilder.Append('_');
                    return Other(str, stringBuilder, i);
                }
                if (char.IsLetter(ch) || (ch == '_'))
                {
                    return Other(str, stringBuilder, i);
                }
            }
            return "_";
        }

        public static bool IsValidNamespace(ReadOnlySpan<char> @namespace)
        {
            if (@namespace.IsEmpty)
            {
                return true;
            }
            if (@namespace[^1] == '.')
            {
                return false;
            }

            int indexStart = 0;
            int indexDot = @namespace[indexStart..].IndexOf('.');
            while (indexDot != -1)
            {
                // Получаем текущий сегмент (до точки)
                ReadOnlySpan<char> segment = @namespace.Slice(indexStart, indexDot);

                // Проверяем валидность сегмента
                if (IsInvalidID(segment))
                {
                    return false;
                }
                indexStart += indexDot + 1;
                indexDot = @namespace[indexStart..].IndexOf('.');
            }
            // Проверяем последний сегмент после последней точки
            ReadOnlySpan<char> lastSegment = @namespace[indexStart..];
            return IsValidID(lastSegment);
        }

        public static bool IsInvalidID(ReadOnlySpan<char> id) => !IsValidID(id);

        public static bool IsValidID(ReadOnlySpan<char> id)
        {
            if (id.IsEmpty)
            {
                return false;
            }
            char firstChar = id[0];
            if (IsInvalidIDFirstChar(firstChar))
            {
                return false;
            }
            ReadOnlySpan<char> chars = id[1..];
            return IsValidIDChars(chars);
        }

        public static bool IsInvalidIDChars(ReadOnlySpan<char> chars) => !IsValidIDChars(chars);

        public static bool IsValidIDChars(ReadOnlySpan<char> chars)
        {
            foreach (char ch in chars)
            {
                if (IsInvalidIDChar(ch))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsValidIDChar(char ch) => (ch == '_') || char.IsLetterOrDigit(ch);

        public static bool IsValidIDFirstChar(char ch)
            => (ch == '_') || (ch == '@') || char.IsLetter(ch);

        public static bool IsInvalidIDChar(char ch) => !IsValidIDChar(ch);

        public static bool IsInvalidIDFirstChar(char ch) => !IsValidIDFirstChar(ch);
    }
}
