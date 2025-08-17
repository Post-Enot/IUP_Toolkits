using System;
using System.IO;
using System.Linq;
using UnityEngine;

namespace IUP.Toolkits
{
    public static class IUP_Path
    {
        public static string GetExtension(string path) => Path.GetExtension(path);

        public static bool IsInvalidFilePath(string path, string extension)
            => !IsValidFilePath(path, extension);

        public static bool IsValidFilePath(string path, string extension)
            => IsValidPath(path) && path.EndsWith(extension);

        public static bool IsInvalidPath(string path) => !IsValidPath(path);

        public static bool IsValidPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return false;
            }
            char[] invalidPathChars = Path.GetInvalidPathChars();
            foreach (char ch in path)
            {
                if (invalidPathChars.Contains(ch))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsValidExtension(string extension)
        {
            if (string.IsNullOrEmpty(extension))
            {
                return false;
            }
            char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
            foreach (char ch in extension)
            {
                if (invalidFileNameChars.Contains(ch))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
