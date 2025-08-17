using UnityEngine;

namespace IUP.Toolkits
{
    public static class Vector
    {
        public static Vector2 X(float x) => new(x, 0.0f);

        public static Vector2 Y(float y) => new(0.0f, y);

        public static Vector3 Z(float z) => new(0.0f, 0.0f, z);

        public static Vector2 XY(float x, float y) => new(x, y);

        public static Vector3 XYZ(float x, float y, float z) => new(x, y, z);

        public static Vector3 XZ(float x, float z) => new(x, 0.0f, z);

        public static Vector3 YZ(float y, float z) => new(0.0f, y, z);
    }
}
