using System.ComponentModel;
using UnityEngine;

namespace IUP.Toolkits
{
    public static class ExtensionVectors
    {
        #region IsZero
        public static bool IsZero(this Vector2 self) => self == Vector2.zero;

        public static bool IsZero(this Vector2Int self) => self == Vector2Int.zero;

        public static bool IsZero(this Vector3 self) => self == Vector3.zero;

        public static bool IsZero(this Vector3Int self) => self == Vector3Int.zero;
        #endregion

        #region IsNotZero
        public static bool IsNotZero(this Vector2 self) => self != Vector2.zero;

        public static bool IsNotZero(this Vector2Int self) => self != Vector2Int.zero;

        public static bool IsNotZero(this Vector3 self) => self != Vector3.zero;

        public static bool IsNotZero(this Vector3Int self) => self == Vector3Int.zero;
        #endregion

        #region WithVector2
        public static Vector2 WithX(this Vector2 self, float x) => new(x, self.y);

        public static Vector2 WithY(this Vector2 self, float y) => new(self.x, y);

        public static Vector3 WithZ(this Vector2 self, float z) => new(self.x, self.y, z);

        public static Vector3 WithXZ(this Vector2 self, float x, float z) => new(x, self.y, z);

        public static Vector3 WithYZ(this Vector2 self, float y, float z) => new(self.x, y, z);

        public static Vector4 WithZW(this Vector2 self, float z, float w) => new(self.x, self.y, z, w);

        public static Vector4 WithXZW(this Vector2 self, float x, float z, float w) => new(x, self.y, z, w);

        public static Vector4 WithYZW(this Vector2 self, float y, float z, float w) => new(self.x, y, z, w);
        #endregion

        #region InvertVector2
        public static Vector2 InvertX(this Vector2 self) => new(-self.x, self.y);

        public static Vector2 InvertY(this Vector2 self) => new(self.x, -self.y);

        public static Vector2 Invert(this Vector2 self) => new(-self.x, -self.y);
        #endregion

        #region WithVector2Int
        public static Vector2Int WithX(this Vector2Int self, int x) => new(x, self.y);

        public static Vector2Int WithY(this Vector2Int self, int y) => new(self.x, y);

        public static Vector3Int WithZ(this Vector2Int self, int z) => new(self.x, self.y, z);

        public static Vector3Int WithXZ(this Vector2Int self, int x, int z) => new(x, self.y, z);

        public static Vector3Int WithYZ(this Vector2Int self, int y, int z) => new(self.x, y, z);
        #endregion

        #region InvertVector2Int
        public static Vector2Int InvertX(this Vector2Int self) => new(-self.x, self.y);

        public static Vector2Int InvertY(this Vector2Int self) => new(self.x, -self.y);

        public static Vector2Int Invert(this Vector2Int self) => new(-self.x, -self.y);
        #endregion

        #region WithVector3
        public static Vector3 WithX(this Vector3 self, float x) => new(x, self.y, self.z);

        public static Vector3 WithY(this Vector3 self, float y) => new(self.x, y, self.z);

        public static Vector3 WithZ(this Vector3 self, float z) => new(self.x, self.y, z);

        public static Vector4 WithW(this Vector3 self, float w) => new(self.x, self.y, self.z, w);

        public static Vector3 WithXY(this Vector3 self, float x, float y) => new(x, y, self.z);

        public static Vector3 WithXZ(this Vector3 self, float x, float z) => new(x, self.y, z);

        public static Vector3 WithYZ(this Vector3 self, float y, float z) => new(self.x, y, z);

        public static Vector4 WithXW(this Vector3 self, float x, float w) => new(x, self.y, self.z, w);

        public static Vector4 WithYW(this Vector3 self, float y, float w) => new(self.x, y, self.z, w);

        public static Vector4 WithZW(this Vector3 self, float z, float w) => new(self.x, self.y, z, w);

        public static Vector4 WithXYW(this Vector3 self, float x, float y, float w) => new(x, y, self.z, w);

        public static Vector4 WithXZW(this Vector3 self, float x, float z, float w) => new(x, self.y, z, w);

        public static Vector4 WithYZW(this Vector3 self, float y, float z, float w) => new(self.x, y, z, w);
        #endregion

        #region InvertVector3
        public static Vector3 InvertX(this Vector3 self) => new(-self.x, self.y, self.z);

        public static Vector3 InvertY(this Vector3 self) => new(self.x, -self.y, self.z);

        public static Vector3 InvertZ(this Vector3 self) => new(self.x, self.y, -self.z);

        public static Vector3 InvertXY(this Vector3 self) => new(-self.x, -self.y, self.z);

        public static Vector3 InvertXZ(this Vector3 self) => new(-self.x, self.y, -self.z);

        public static Vector3 InvertYZ(this Vector3 self) => new(self.x, -self.y, -self.z);

        public static Vector3 Invert(this Vector3 self) => new(-self.x, -self.y, -self.z);
        #endregion

        #region WithVector3Int
        public static Vector3Int WithX(this Vector3Int self, int x) => new(x, self.y, self.z);

        public static Vector3Int WithY(this Vector3Int self, int y) => new(self.x, y, self.z);

        public static Vector3Int WithZ(this Vector3Int self, int z) => new(self.x, self.y, z);

        public static Vector3Int WithXY(this Vector3Int self, int x, int y) => new(x, y, self.z);

        public static Vector3Int WithXZ(this Vector3Int self, int x, int z) => new(x, self.y, z);

        public static Vector3Int WithYZ(this Vector3Int self, int y, int z) => new(self.x, y, z);
        #endregion

        #region InvertVector3Int
        public static Vector3Int InvertX(this Vector3Int self) => new(-self.x, self.y, self.z);

        public static Vector3Int InvertY(this Vector3Int self) => new(self.x, -self.y, self.z);

        public static Vector3Int InvertZ(this Vector3Int self) => new(self.x, self.y, -self.z);

        public static Vector3Int InvertXY(this Vector3Int self) => new(-self.x, -self.y, self.z);

        public static Vector3Int InvertXZ(this Vector3Int self) => new(-self.x, self.y, -self.z);

        public static Vector3Int InvertYZ(this Vector3Int self) => new(self.x, -self.y, -self.z);

        public static Vector3Int Invert(this Vector3Int self) => new(-self.x, -self.y, -self.z);
        #endregion

        #region WithVector4
        public static Vector4 WithX(this Vector4 self, float x) => new(x, self.y, self.z, self.w);

        public static Vector4 WithY(this Vector4 self, float y) => new(self.x, y, self.z, self.w);

        public static Vector4 WithZ(this Vector4 self, float z) => new(self.x, self.y, z, self.w);

        public static Vector4 WithW(this Vector4 self, float w) => new(self.x, self.y, self.z, w);

        public static Vector4 WithXY(this Vector4 self, float x, float y) => new(x, y, self.z, self.w);

        public static Vector4 WithXZ(this Vector4 self, float x, float z) => new(x, self.y, z, self.w);

        public static Vector4 WithXW(this Vector4 self, float x, float w) => new(x, self.y, self.z, w);

        public static Vector4 WithYZ(this Vector4 self, float y, float z) => new(self.x, y, z, self.w);

        public static Vector4 WithYW(this Vector4 self, float y, float w) => new(self.x, y, self.z, w);

        public static Vector4 WithZW(this Vector4 self, float z, float w) => new(self.x, self.y, z, w);

        public static Vector4 WithXYZ(this Vector4 self, float x, float y, float z) => new(x, y, z, self.w);

        public static Vector4 WithXYW(this Vector4 self, float x, float y, float w) => new(x, y, self.z, w);

        public static Vector4 WithXZW(this Vector4 self, float x, float z, float w) => new(x, self.y, z, w);

        public static Vector4 WithYZW(this Vector4 self, float y, float z, float w) => new(self.x, y, z, w);
        #endregion

        #region InvertVector4
        public static Vector4 InvertX(this Vector4 self) => new(-self.x, self.y, self.z, self.w);

        public static Vector4 InvertY(this Vector4 self) => new(self.x, -self.y, self.z, self.w);

        public static Vector4 InvertZ(this Vector4 self) => new(self.x, self.y, -self.z, self.w);

        public static Vector4 InvertW(this Vector4 self) => new(self.x, self.y, self.z, -self.w);

        public static Vector4 InvertXY(this Vector4 self) => new(-self.x, -self.y, self.z, self.w);

        public static Vector4 InvertXZ(this Vector4 self) => new(-self.x, self.y, -self.z, self.w);

        public static Vector4 InvertXW(this Vector4 self) => new(-self.x, self.y, self.z, -self.w);

        public static Vector4 InvertYZ(this Vector4 self) => new(self.x, -self.y, -self.z, self.w);

        public static Vector4 InvertYW(this Vector4 self) => new(self.x, -self.y, self.z, -self.w);

        public static Vector4 InvertZW(this Vector4 self) => new(self.x, self.y, -self.z, -self.w);

        public static Vector4 InvertXYZ(this Vector4 self) => new(-self.x, -self.y, -self.z, self.w);

        public static Vector4 InvertXYW(this Vector4 self) => new(-self.x, -self.y, self.z, -self.w);

        public static Vector4 InvertXZW(this Vector4 self) => new(-self.x, self.y, -self.z, -self.w);

        public static Vector4 InvertYZW(this Vector4 self) => new(self.x, -self.y, -self.z, -self.w);

        public static Vector4 Invert(this Vector4 self) => new(-self.x, -self.y, -self.z, -self.w);
        #endregion

        #region SwizzleVector2
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 xx(this Vector2 v) => new(v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 xy(this Vector2 v) => new(v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 x_(this Vector2 v) => new(v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 yx(this Vector2 v) => new(v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 yy(this Vector2 v) => new(v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 y_(this Vector2 v) => new(v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 _x(this Vector2 v) => new(0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 _y(this Vector2 v) => new(0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xxx(this Vector2 v) => new(v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xxy(this Vector2 v) => new(v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xx_(this Vector2 v) => new(v.x, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xyx(this Vector2 v) => new(v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xyy(this Vector2 v) => new(v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xy_(this Vector2 v) => new(v.x, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 x_x(this Vector2 v) => new(v.x, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 x_y(this Vector2 v) => new(v.x, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 x__(this Vector2 v) => new(v.x, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yxx(this Vector2 v) => new(v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yxy(this Vector2 v) => new(v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yx_(this Vector2 v) => new(v.y, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yyx(this Vector2 v) => new(v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yyy(this Vector2 v) => new(v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yy_(this Vector2 v) => new(v.y, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 y_x(this Vector2 v) => new(v.y, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 y_y(this Vector2 v) => new(v.y, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 y__(this Vector2 v) => new(v.y, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _xx(this Vector2 v) => new(0.0f, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _xy(this Vector2 v) => new(0.0f, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _x_(this Vector2 v) => new(0.0f, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _yx(this Vector2 v) => new(0.0f, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _yy(this Vector2 v) => new(0.0f, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _y_(this Vector2 v) => new(0.0f, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 __x(this Vector2 v) => new(0.0f, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 __y(this Vector2 v) => new(0.0f, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxxx(this Vector2 v) => new(v.x, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxxy(this Vector2 v) => new(v.x, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxx_(this Vector2 v) => new(v.x, v.x, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxyx(this Vector2 v) => new(v.x, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxyy(this Vector2 v) => new(v.x, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxy_(this Vector2 v) => new(v.x, v.x, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx_x(this Vector2 v) => new(v.x, v.x, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx_y(this Vector2 v) => new(v.x, v.x, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx__(this Vector2 v) => new(v.x, v.x, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyxx(this Vector2 v) => new(v.x, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyxy(this Vector2 v) => new(v.x, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyx_(this Vector2 v) => new(v.x, v.y, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyyx(this Vector2 v) => new(v.x, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyyy(this Vector2 v) => new(v.x, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyy_(this Vector2 v) => new(v.x, v.y, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy_x(this Vector2 v) => new(v.x, v.y, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy_y(this Vector2 v) => new(v.x, v.y, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy__(this Vector2 v) => new(v.x, v.y, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_xx(this Vector2 v) => new(v.x, 0.0f, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_xy(this Vector2 v) => new(v.x, 0.0f, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_x_(this Vector2 v) => new(v.x, 0.0f, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_yx(this Vector2 v) => new(v.x, 0.0f, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_yy(this Vector2 v) => new(v.x, 0.0f, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_y_(this Vector2 v) => new(v.x, 0.0f, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x__x(this Vector2 v) => new(v.x, 0.0f, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x__y(this Vector2 v) => new(v.x, 0.0f, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x___(this Vector2 v) => new(v.x, 0.0f, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxxx(this Vector2 v) => new(v.y, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxxy(this Vector2 v) => new(v.y, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxx_(this Vector2 v) => new(v.y, v.x, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxyx(this Vector2 v) => new(v.y, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxyy(this Vector2 v) => new(v.y, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxy_(this Vector2 v) => new(v.y, v.x, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx_x(this Vector2 v) => new(v.y, v.x, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx_y(this Vector2 v) => new(v.y, v.x, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx__(this Vector2 v) => new(v.y, v.x, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyxx(this Vector2 v) => new(v.y, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyxy(this Vector2 v) => new(v.y, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyx_(this Vector2 v) => new(v.y, v.y, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyyx(this Vector2 v) => new(v.y, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyyy(this Vector2 v) => new(v.y, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyy_(this Vector2 v) => new(v.y, v.y, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy_x(this Vector2 v) => new(v.y, v.y, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy_y(this Vector2 v) => new(v.y, v.y, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy__(this Vector2 v) => new(v.y, v.y, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_xx(this Vector2 v) => new(v.y, 0.0f, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_xy(this Vector2 v) => new(v.y, 0.0f, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_x_(this Vector2 v) => new(v.y, 0.0f, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_yx(this Vector2 v) => new(v.y, 0.0f, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_yy(this Vector2 v) => new(v.y, 0.0f, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_y_(this Vector2 v) => new(v.y, 0.0f, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y__x(this Vector2 v) => new(v.y, 0.0f, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y__y(this Vector2 v) => new(v.y, 0.0f, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y___(this Vector2 v) => new(v.y, 0.0f, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xxx(this Vector2 v) => new(0.0f, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xxy(this Vector2 v) => new(0.0f, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xx_(this Vector2 v) => new(0.0f, v.x, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xyx(this Vector2 v) => new(0.0f, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xyy(this Vector2 v) => new(0.0f, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xy_(this Vector2 v) => new(0.0f, v.x, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x_x(this Vector2 v) => new(0.0f, v.x, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x_y(this Vector2 v) => new(0.0f, v.x, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x__(this Vector2 v) => new(0.0f, v.x, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yxx(this Vector2 v) => new(0.0f, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yxy(this Vector2 v) => new(0.0f, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yx_(this Vector2 v) => new(0.0f, v.y, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yyx(this Vector2 v) => new(0.0f, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yyy(this Vector2 v) => new(0.0f, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yy_(this Vector2 v) => new(0.0f, v.y, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y_x(this Vector2 v) => new(0.0f, v.y, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y_y(this Vector2 v) => new(0.0f, v.y, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y__(this Vector2 v) => new(0.0f, v.y, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __xx(this Vector2 v) => new(0.0f, 0.0f, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __xy(this Vector2 v) => new(0.0f, 0.0f, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __x_(this Vector2 v) => new(0.0f, 0.0f, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __yx(this Vector2 v) => new(0.0f, 0.0f, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __yy(this Vector2 v) => new(0.0f, 0.0f, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __y_(this Vector2 v) => new(0.0f, 0.0f, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ___x(this Vector2 v) => new(0.0f, 0.0f, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ___y(this Vector2 v) => new(0.0f, 0.0f, 0.0f, v.y);

        #endregion

        #region SwizzleVector2Int
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int xx(this Vector2Int v) => new(v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int xy(this Vector2Int v) => new(v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int x_(this Vector2Int v) => new(v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int yx(this Vector2Int v) => new(v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int yy(this Vector2Int v) => new(v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int y_(this Vector2Int v) => new(v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int _x(this Vector2Int v) => new(0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int _y(this Vector2Int v) => new(0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xxx(this Vector2Int v) => new(v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xxy(this Vector2Int v) => new(v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xx_(this Vector2Int v) => new(v.x, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xyx(this Vector2Int v) => new(v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xyy(this Vector2Int v) => new(v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xy_(this Vector2Int v) => new(v.x, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int x_x(this Vector2Int v) => new(v.x, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int x_y(this Vector2Int v) => new(v.x, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int x__(this Vector2Int v) => new(v.x, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yxx(this Vector2Int v) => new(v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yxy(this Vector2Int v) => new(v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yx_(this Vector2Int v) => new(v.y, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yyx(this Vector2Int v) => new(v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yyy(this Vector2Int v) => new(v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yy_(this Vector2Int v) => new(v.y, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int y_x(this Vector2Int v) => new(v.y, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int y_y(this Vector2Int v) => new(v.y, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int y__(this Vector2Int v) => new(v.y, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _xx(this Vector2Int v) => new(0, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _xy(this Vector2Int v) => new(0, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _x_(this Vector2Int v) => new(0, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _yx(this Vector2Int v) => new(0, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _yy(this Vector2Int v) => new(0, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _y_(this Vector2Int v) => new(0, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int __x(this Vector2Int v) => new(0, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int __y(this Vector2Int v) => new(0, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxxx(this Vector2Int v) => new(v.x, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxxy(this Vector2Int v) => new(v.x, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxx_(this Vector2Int v) => new(v.x, v.x, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxyx(this Vector2Int v) => new(v.x, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxyy(this Vector2Int v) => new(v.x, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxy_(this Vector2Int v) => new(v.x, v.x, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx_x(this Vector2Int v) => new(v.x, v.x, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx_y(this Vector2Int v) => new(v.x, v.x, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx__(this Vector2Int v) => new(v.x, v.x, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyxx(this Vector2Int v) => new(v.x, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyxy(this Vector2Int v) => new(v.x, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyx_(this Vector2Int v) => new(v.x, v.y, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyyx(this Vector2Int v) => new(v.x, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyyy(this Vector2Int v) => new(v.x, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyy_(this Vector2Int v) => new(v.x, v.y, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy_x(this Vector2Int v) => new(v.x, v.y, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy_y(this Vector2Int v) => new(v.x, v.y, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy__(this Vector2Int v) => new(v.x, v.y, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_xx(this Vector2Int v) => new(v.x, 0, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_xy(this Vector2Int v) => new(v.x, 0, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_x_(this Vector2Int v) => new(v.x, 0, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_yx(this Vector2Int v) => new(v.x, 0, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_yy(this Vector2Int v) => new(v.x, 0, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_y_(this Vector2Int v) => new(v.x, 0, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x__x(this Vector2Int v) => new(v.x, 0, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x__y(this Vector2Int v) => new(v.x, 0, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x___(this Vector2Int v) => new(v.x, 0, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxxx(this Vector2Int v) => new(v.y, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxxy(this Vector2Int v) => new(v.y, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxx_(this Vector2Int v) => new(v.y, v.x, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxyx(this Vector2Int v) => new(v.y, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxyy(this Vector2Int v) => new(v.y, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxy_(this Vector2Int v) => new(v.y, v.x, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx_x(this Vector2Int v) => new(v.y, v.x, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx_y(this Vector2Int v) => new(v.y, v.x, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx__(this Vector2Int v) => new(v.y, v.x, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyxx(this Vector2Int v) => new(v.y, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyxy(this Vector2Int v) => new(v.y, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyx_(this Vector2Int v) => new(v.y, v.y, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyyx(this Vector2Int v) => new(v.y, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyyy(this Vector2Int v) => new(v.y, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyy_(this Vector2Int v) => new(v.y, v.y, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy_x(this Vector2Int v) => new(v.y, v.y, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy_y(this Vector2Int v) => new(v.y, v.y, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy__(this Vector2Int v) => new(v.y, v.y, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_xx(this Vector2Int v) => new(v.y, 0, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_xy(this Vector2Int v) => new(v.y, 0, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_x_(this Vector2Int v) => new(v.y, 0, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_yx(this Vector2Int v) => new(v.y, 0, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_yy(this Vector2Int v) => new(v.y, 0, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_y_(this Vector2Int v) => new(v.y, 0, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y__x(this Vector2Int v) => new(v.y, 0, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y__y(this Vector2Int v) => new(v.y, 0, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y___(this Vector2Int v) => new(v.y, 0, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xxx(this Vector2Int v) => new(0, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xxy(this Vector2Int v) => new(0, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xx_(this Vector2Int v) => new(0, v.x, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xyx(this Vector2Int v) => new(0, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xyy(this Vector2Int v) => new(0, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xy_(this Vector2Int v) => new(0, v.x, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x_x(this Vector2Int v) => new(0, v.x, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x_y(this Vector2Int v) => new(0, v.x, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x__(this Vector2Int v) => new(0, v.x, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yxx(this Vector2Int v) => new(0, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yxy(this Vector2Int v) => new(0, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yx_(this Vector2Int v) => new(0, v.y, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yyx(this Vector2Int v) => new(0, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yyy(this Vector2Int v) => new(0, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yy_(this Vector2Int v) => new(0, v.y, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y_x(this Vector2Int v) => new(0, v.y, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y_y(this Vector2Int v) => new(0, v.y, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y__(this Vector2Int v) => new(0, v.y, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __xx(this Vector2Int v) => new(0, 0, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __xy(this Vector2Int v) => new(0, 0, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __x_(this Vector2Int v) => new(0, 0, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __yx(this Vector2Int v) => new(0, 0, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __yy(this Vector2Int v) => new(0, 0, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __y_(this Vector2Int v) => new(0, 0, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ___x(this Vector2Int v) => new(0, 0, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ___y(this Vector2Int v) => new(0, 0, 0, v.y);

        #endregion

        #region SwizzleVector3
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 xx(this Vector3 v) => new(v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 xy(this Vector3 v) => new(v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 xz(this Vector3 v) => new(v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 x_(this Vector3 v) => new(v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 yx(this Vector3 v) => new(v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 yy(this Vector3 v) => new(v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 yz(this Vector3 v) => new(v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 y_(this Vector3 v) => new(v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 zx(this Vector3 v) => new(v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 zy(this Vector3 v) => new(v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 zz(this Vector3 v) => new(v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 z_(this Vector3 v) => new(v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 _x(this Vector3 v) => new(0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 _y(this Vector3 v) => new(0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 _z(this Vector3 v) => new(0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xxx(this Vector3 v) => new(v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xxy(this Vector3 v) => new(v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xxz(this Vector3 v) => new(v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xx_(this Vector3 v) => new(v.x, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xyx(this Vector3 v) => new(v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xyy(this Vector3 v) => new(v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xyz(this Vector3 v) => new(v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xy_(this Vector3 v) => new(v.x, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xzx(this Vector3 v) => new(v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xzy(this Vector3 v) => new(v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xzz(this Vector3 v) => new(v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xz_(this Vector3 v) => new(v.x, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 x_x(this Vector3 v) => new(v.x, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 x_y(this Vector3 v) => new(v.x, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 x_z(this Vector3 v) => new(v.x, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 x__(this Vector3 v) => new(v.x, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yxx(this Vector3 v) => new(v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yxy(this Vector3 v) => new(v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yxz(this Vector3 v) => new(v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yx_(this Vector3 v) => new(v.y, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yyx(this Vector3 v) => new(v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yyy(this Vector3 v) => new(v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yyz(this Vector3 v) => new(v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yy_(this Vector3 v) => new(v.y, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yzx(this Vector3 v) => new(v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yzy(this Vector3 v) => new(v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yzz(this Vector3 v) => new(v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yz_(this Vector3 v) => new(v.y, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 y_x(this Vector3 v) => new(v.y, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 y_y(this Vector3 v) => new(v.y, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 y_z(this Vector3 v) => new(v.y, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 y__(this Vector3 v) => new(v.y, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zxx(this Vector3 v) => new(v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zxy(this Vector3 v) => new(v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zxz(this Vector3 v) => new(v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zx_(this Vector3 v) => new(v.z, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zyx(this Vector3 v) => new(v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zyy(this Vector3 v) => new(v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zyz(this Vector3 v) => new(v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zy_(this Vector3 v) => new(v.z, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zzx(this Vector3 v) => new(v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zzy(this Vector3 v) => new(v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zzz(this Vector3 v) => new(v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zz_(this Vector3 v) => new(v.z, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 z_x(this Vector3 v) => new(v.z, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 z_y(this Vector3 v) => new(v.z, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 z_z(this Vector3 v) => new(v.z, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 z__(this Vector3 v) => new(v.z, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _xx(this Vector3 v) => new(0.0f, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _xy(this Vector3 v) => new(0.0f, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _xz(this Vector3 v) => new(0.0f, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _x_(this Vector3 v) => new(0.0f, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _yx(this Vector3 v) => new(0.0f, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _yy(this Vector3 v) => new(0.0f, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _yz(this Vector3 v) => new(0.0f, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _y_(this Vector3 v) => new(0.0f, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _zx(this Vector3 v) => new(0.0f, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _zy(this Vector3 v) => new(0.0f, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _zz(this Vector3 v) => new(0.0f, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _z_(this Vector3 v) => new(0.0f, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 __x(this Vector3 v) => new(0.0f, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 __y(this Vector3 v) => new(0.0f, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 __z(this Vector3 v) => new(0.0f, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxxx(this Vector3 v) => new(v.x, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxxy(this Vector3 v) => new(v.x, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxxz(this Vector3 v) => new(v.x, v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxx_(this Vector3 v) => new(v.x, v.x, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxyx(this Vector3 v) => new(v.x, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxyy(this Vector3 v) => new(v.x, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxyz(this Vector3 v) => new(v.x, v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxy_(this Vector3 v) => new(v.x, v.x, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxzx(this Vector3 v) => new(v.x, v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxzy(this Vector3 v) => new(v.x, v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxzz(this Vector3 v) => new(v.x, v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxz_(this Vector3 v) => new(v.x, v.x, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx_x(this Vector3 v) => new(v.x, v.x, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx_y(this Vector3 v) => new(v.x, v.x, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx_z(this Vector3 v) => new(v.x, v.x, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx__(this Vector3 v) => new(v.x, v.x, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyxx(this Vector3 v) => new(v.x, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyxy(this Vector3 v) => new(v.x, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyxz(this Vector3 v) => new(v.x, v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyx_(this Vector3 v) => new(v.x, v.y, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyyx(this Vector3 v) => new(v.x, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyyy(this Vector3 v) => new(v.x, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyyz(this Vector3 v) => new(v.x, v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyy_(this Vector3 v) => new(v.x, v.y, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyzx(this Vector3 v) => new(v.x, v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyzy(this Vector3 v) => new(v.x, v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyzz(this Vector3 v) => new(v.x, v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyz_(this Vector3 v) => new(v.x, v.y, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy_x(this Vector3 v) => new(v.x, v.y, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy_y(this Vector3 v) => new(v.x, v.y, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy_z(this Vector3 v) => new(v.x, v.y, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy__(this Vector3 v) => new(v.x, v.y, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzxx(this Vector3 v) => new(v.x, v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzxy(this Vector3 v) => new(v.x, v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzxz(this Vector3 v) => new(v.x, v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzx_(this Vector3 v) => new(v.x, v.z, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzyx(this Vector3 v) => new(v.x, v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzyy(this Vector3 v) => new(v.x, v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzyz(this Vector3 v) => new(v.x, v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzy_(this Vector3 v) => new(v.x, v.z, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzzx(this Vector3 v) => new(v.x, v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzzy(this Vector3 v) => new(v.x, v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzzz(this Vector3 v) => new(v.x, v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzz_(this Vector3 v) => new(v.x, v.z, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xz_x(this Vector3 v) => new(v.x, v.z, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xz_y(this Vector3 v) => new(v.x, v.z, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xz_z(this Vector3 v) => new(v.x, v.z, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xz__(this Vector3 v) => new(v.x, v.z, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_xx(this Vector3 v) => new(v.x, 0.0f, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_xy(this Vector3 v) => new(v.x, 0.0f, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_xz(this Vector3 v) => new(v.x, 0.0f, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_x_(this Vector3 v) => new(v.x, 0.0f, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_yx(this Vector3 v) => new(v.x, 0.0f, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_yy(this Vector3 v) => new(v.x, 0.0f, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_yz(this Vector3 v) => new(v.x, 0.0f, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_y_(this Vector3 v) => new(v.x, 0.0f, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_zx(this Vector3 v) => new(v.x, 0.0f, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_zy(this Vector3 v) => new(v.x, 0.0f, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_zz(this Vector3 v) => new(v.x, 0.0f, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_z_(this Vector3 v) => new(v.x, 0.0f, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x__x(this Vector3 v) => new(v.x, 0.0f, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x__y(this Vector3 v) => new(v.x, 0.0f, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x__z(this Vector3 v) => new(v.x, 0.0f, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x___(this Vector3 v) => new(v.x, 0.0f, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxxx(this Vector3 v) => new(v.y, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxxy(this Vector3 v) => new(v.y, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxxz(this Vector3 v) => new(v.y, v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxx_(this Vector3 v) => new(v.y, v.x, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxyx(this Vector3 v) => new(v.y, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxyy(this Vector3 v) => new(v.y, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxyz(this Vector3 v) => new(v.y, v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxy_(this Vector3 v) => new(v.y, v.x, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxzx(this Vector3 v) => new(v.y, v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxzy(this Vector3 v) => new(v.y, v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxzz(this Vector3 v) => new(v.y, v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxz_(this Vector3 v) => new(v.y, v.x, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx_x(this Vector3 v) => new(v.y, v.x, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx_y(this Vector3 v) => new(v.y, v.x, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx_z(this Vector3 v) => new(v.y, v.x, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx__(this Vector3 v) => new(v.y, v.x, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyxx(this Vector3 v) => new(v.y, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyxy(this Vector3 v) => new(v.y, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyxz(this Vector3 v) => new(v.y, v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyx_(this Vector3 v) => new(v.y, v.y, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyyx(this Vector3 v) => new(v.y, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyyy(this Vector3 v) => new(v.y, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyyz(this Vector3 v) => new(v.y, v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyy_(this Vector3 v) => new(v.y, v.y, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyzx(this Vector3 v) => new(v.y, v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyzy(this Vector3 v) => new(v.y, v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyzz(this Vector3 v) => new(v.y, v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyz_(this Vector3 v) => new(v.y, v.y, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy_x(this Vector3 v) => new(v.y, v.y, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy_y(this Vector3 v) => new(v.y, v.y, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy_z(this Vector3 v) => new(v.y, v.y, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy__(this Vector3 v) => new(v.y, v.y, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzxx(this Vector3 v) => new(v.y, v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzxy(this Vector3 v) => new(v.y, v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzxz(this Vector3 v) => new(v.y, v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzx_(this Vector3 v) => new(v.y, v.z, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzyx(this Vector3 v) => new(v.y, v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzyy(this Vector3 v) => new(v.y, v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzyz(this Vector3 v) => new(v.y, v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzy_(this Vector3 v) => new(v.y, v.z, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzzx(this Vector3 v) => new(v.y, v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzzy(this Vector3 v) => new(v.y, v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzzz(this Vector3 v) => new(v.y, v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzz_(this Vector3 v) => new(v.y, v.z, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yz_x(this Vector3 v) => new(v.y, v.z, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yz_y(this Vector3 v) => new(v.y, v.z, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yz_z(this Vector3 v) => new(v.y, v.z, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yz__(this Vector3 v) => new(v.y, v.z, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_xx(this Vector3 v) => new(v.y, 0.0f, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_xy(this Vector3 v) => new(v.y, 0.0f, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_xz(this Vector3 v) => new(v.y, 0.0f, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_x_(this Vector3 v) => new(v.y, 0.0f, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_yx(this Vector3 v) => new(v.y, 0.0f, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_yy(this Vector3 v) => new(v.y, 0.0f, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_yz(this Vector3 v) => new(v.y, 0.0f, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_y_(this Vector3 v) => new(v.y, 0.0f, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_zx(this Vector3 v) => new(v.y, 0.0f, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_zy(this Vector3 v) => new(v.y, 0.0f, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_zz(this Vector3 v) => new(v.y, 0.0f, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_z_(this Vector3 v) => new(v.y, 0.0f, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y__x(this Vector3 v) => new(v.y, 0.0f, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y__y(this Vector3 v) => new(v.y, 0.0f, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y__z(this Vector3 v) => new(v.y, 0.0f, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y___(this Vector3 v) => new(v.y, 0.0f, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxxx(this Vector3 v) => new(v.z, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxxy(this Vector3 v) => new(v.z, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxxz(this Vector3 v) => new(v.z, v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxx_(this Vector3 v) => new(v.z, v.x, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxyx(this Vector3 v) => new(v.z, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxyy(this Vector3 v) => new(v.z, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxyz(this Vector3 v) => new(v.z, v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxy_(this Vector3 v) => new(v.z, v.x, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxzx(this Vector3 v) => new(v.z, v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxzy(this Vector3 v) => new(v.z, v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxzz(this Vector3 v) => new(v.z, v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxz_(this Vector3 v) => new(v.z, v.x, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zx_x(this Vector3 v) => new(v.z, v.x, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zx_y(this Vector3 v) => new(v.z, v.x, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zx_z(this Vector3 v) => new(v.z, v.x, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zx__(this Vector3 v) => new(v.z, v.x, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyxx(this Vector3 v) => new(v.z, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyxy(this Vector3 v) => new(v.z, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyxz(this Vector3 v) => new(v.z, v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyx_(this Vector3 v) => new(v.z, v.y, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyyx(this Vector3 v) => new(v.z, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyyy(this Vector3 v) => new(v.z, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyyz(this Vector3 v) => new(v.z, v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyy_(this Vector3 v) => new(v.z, v.y, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyzx(this Vector3 v) => new(v.z, v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyzy(this Vector3 v) => new(v.z, v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyzz(this Vector3 v) => new(v.z, v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyz_(this Vector3 v) => new(v.z, v.y, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zy_x(this Vector3 v) => new(v.z, v.y, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zy_y(this Vector3 v) => new(v.z, v.y, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zy_z(this Vector3 v) => new(v.z, v.y, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zy__(this Vector3 v) => new(v.z, v.y, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzxx(this Vector3 v) => new(v.z, v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzxy(this Vector3 v) => new(v.z, v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzxz(this Vector3 v) => new(v.z, v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzx_(this Vector3 v) => new(v.z, v.z, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzyx(this Vector3 v) => new(v.z, v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzyy(this Vector3 v) => new(v.z, v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzyz(this Vector3 v) => new(v.z, v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzy_(this Vector3 v) => new(v.z, v.z, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzzx(this Vector3 v) => new(v.z, v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzzy(this Vector3 v) => new(v.z, v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzzz(this Vector3 v) => new(v.z, v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzz_(this Vector3 v) => new(v.z, v.z, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zz_x(this Vector3 v) => new(v.z, v.z, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zz_y(this Vector3 v) => new(v.z, v.z, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zz_z(this Vector3 v) => new(v.z, v.z, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zz__(this Vector3 v) => new(v.z, v.z, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_xx(this Vector3 v) => new(v.z, 0.0f, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_xy(this Vector3 v) => new(v.z, 0.0f, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_xz(this Vector3 v) => new(v.z, 0.0f, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_x_(this Vector3 v) => new(v.z, 0.0f, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_yx(this Vector3 v) => new(v.z, 0.0f, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_yy(this Vector3 v) => new(v.z, 0.0f, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_yz(this Vector3 v) => new(v.z, 0.0f, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_y_(this Vector3 v) => new(v.z, 0.0f, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_zx(this Vector3 v) => new(v.z, 0.0f, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_zy(this Vector3 v) => new(v.z, 0.0f, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_zz(this Vector3 v) => new(v.z, 0.0f, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_z_(this Vector3 v) => new(v.z, 0.0f, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z__x(this Vector3 v) => new(v.z, 0.0f, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z__y(this Vector3 v) => new(v.z, 0.0f, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z__z(this Vector3 v) => new(v.z, 0.0f, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z___(this Vector3 v) => new(v.z, 0.0f, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xxx(this Vector3 v) => new(0.0f, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xxy(this Vector3 v) => new(0.0f, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xxz(this Vector3 v) => new(0.0f, v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xx_(this Vector3 v) => new(0.0f, v.x, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xyx(this Vector3 v) => new(0.0f, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xyy(this Vector3 v) => new(0.0f, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xyz(this Vector3 v) => new(0.0f, v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xy_(this Vector3 v) => new(0.0f, v.x, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xzx(this Vector3 v) => new(0.0f, v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xzy(this Vector3 v) => new(0.0f, v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xzz(this Vector3 v) => new(0.0f, v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xz_(this Vector3 v) => new(0.0f, v.x, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x_x(this Vector3 v) => new(0.0f, v.x, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x_y(this Vector3 v) => new(0.0f, v.x, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x_z(this Vector3 v) => new(0.0f, v.x, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x__(this Vector3 v) => new(0.0f, v.x, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yxx(this Vector3 v) => new(0.0f, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yxy(this Vector3 v) => new(0.0f, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yxz(this Vector3 v) => new(0.0f, v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yx_(this Vector3 v) => new(0.0f, v.y, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yyx(this Vector3 v) => new(0.0f, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yyy(this Vector3 v) => new(0.0f, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yyz(this Vector3 v) => new(0.0f, v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yy_(this Vector3 v) => new(0.0f, v.y, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yzx(this Vector3 v) => new(0.0f, v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yzy(this Vector3 v) => new(0.0f, v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yzz(this Vector3 v) => new(0.0f, v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yz_(this Vector3 v) => new(0.0f, v.y, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y_x(this Vector3 v) => new(0.0f, v.y, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y_y(this Vector3 v) => new(0.0f, v.y, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y_z(this Vector3 v) => new(0.0f, v.y, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y__(this Vector3 v) => new(0.0f, v.y, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zxx(this Vector3 v) => new(0.0f, v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zxy(this Vector3 v) => new(0.0f, v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zxz(this Vector3 v) => new(0.0f, v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zx_(this Vector3 v) => new(0.0f, v.z, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zyx(this Vector3 v) => new(0.0f, v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zyy(this Vector3 v) => new(0.0f, v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zyz(this Vector3 v) => new(0.0f, v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zy_(this Vector3 v) => new(0.0f, v.z, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zzx(this Vector3 v) => new(0.0f, v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zzy(this Vector3 v) => new(0.0f, v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zzz(this Vector3 v) => new(0.0f, v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zz_(this Vector3 v) => new(0.0f, v.z, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _z_x(this Vector3 v) => new(0.0f, v.z, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _z_y(this Vector3 v) => new(0.0f, v.z, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _z_z(this Vector3 v) => new(0.0f, v.z, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _z__(this Vector3 v) => new(0.0f, v.z, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __xx(this Vector3 v) => new(0.0f, 0.0f, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __xy(this Vector3 v) => new(0.0f, 0.0f, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __xz(this Vector3 v) => new(0.0f, 0.0f, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __x_(this Vector3 v) => new(0.0f, 0.0f, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __yx(this Vector3 v) => new(0.0f, 0.0f, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __yy(this Vector3 v) => new(0.0f, 0.0f, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __yz(this Vector3 v) => new(0.0f, 0.0f, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __y_(this Vector3 v) => new(0.0f, 0.0f, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __zx(this Vector3 v) => new(0.0f, 0.0f, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __zy(this Vector3 v) => new(0.0f, 0.0f, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __zz(this Vector3 v) => new(0.0f, 0.0f, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __z_(this Vector3 v) => new(0.0f, 0.0f, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ___x(this Vector3 v) => new(0.0f, 0.0f, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ___y(this Vector3 v) => new(0.0f, 0.0f, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ___z(this Vector3 v) => new(0.0f, 0.0f, 0.0f, v.z);

        #endregion

        #region SwizzleVector3Int
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int xx(this Vector3Int v) => new(v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int xy(this Vector3Int v) => new(v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int xz(this Vector3Int v) => new(v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int x_(this Vector3Int v) => new(v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int yx(this Vector3Int v) => new(v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int yy(this Vector3Int v) => new(v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int yz(this Vector3Int v) => new(v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int y_(this Vector3Int v) => new(v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int zx(this Vector3Int v) => new(v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int zy(this Vector3Int v) => new(v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int zz(this Vector3Int v) => new(v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int z_(this Vector3Int v) => new(v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int _x(this Vector3Int v) => new(0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int _y(this Vector3Int v) => new(0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2Int _z(this Vector3Int v) => new(0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xxx(this Vector3Int v) => new(v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xxy(this Vector3Int v) => new(v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xxz(this Vector3Int v) => new(v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xx_(this Vector3Int v) => new(v.x, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xyx(this Vector3Int v) => new(v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xyy(this Vector3Int v) => new(v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xyz(this Vector3Int v) => new(v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xy_(this Vector3Int v) => new(v.x, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xzx(this Vector3Int v) => new(v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xzy(this Vector3Int v) => new(v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xzz(this Vector3Int v) => new(v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int xz_(this Vector3Int v) => new(v.x, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int x_x(this Vector3Int v) => new(v.x, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int x_y(this Vector3Int v) => new(v.x, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int x_z(this Vector3Int v) => new(v.x, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int x__(this Vector3Int v) => new(v.x, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yxx(this Vector3Int v) => new(v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yxy(this Vector3Int v) => new(v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yxz(this Vector3Int v) => new(v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yx_(this Vector3Int v) => new(v.y, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yyx(this Vector3Int v) => new(v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yyy(this Vector3Int v) => new(v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yyz(this Vector3Int v) => new(v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yy_(this Vector3Int v) => new(v.y, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yzx(this Vector3Int v) => new(v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yzy(this Vector3Int v) => new(v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yzz(this Vector3Int v) => new(v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int yz_(this Vector3Int v) => new(v.y, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int y_x(this Vector3Int v) => new(v.y, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int y_y(this Vector3Int v) => new(v.y, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int y_z(this Vector3Int v) => new(v.y, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int y__(this Vector3Int v) => new(v.y, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int zxx(this Vector3Int v) => new(v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int zxy(this Vector3Int v) => new(v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int zxz(this Vector3Int v) => new(v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int zx_(this Vector3Int v) => new(v.z, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int zyx(this Vector3Int v) => new(v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int zyy(this Vector3Int v) => new(v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int zyz(this Vector3Int v) => new(v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int zy_(this Vector3Int v) => new(v.z, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int zzx(this Vector3Int v) => new(v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int zzy(this Vector3Int v) => new(v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int zzz(this Vector3Int v) => new(v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int zz_(this Vector3Int v) => new(v.z, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int z_x(this Vector3Int v) => new(v.z, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int z_y(this Vector3Int v) => new(v.z, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int z_z(this Vector3Int v) => new(v.z, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int z__(this Vector3Int v) => new(v.z, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _xx(this Vector3Int v) => new(0, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _xy(this Vector3Int v) => new(0, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _xz(this Vector3Int v) => new(0, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _x_(this Vector3Int v) => new(0, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _yx(this Vector3Int v) => new(0, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _yy(this Vector3Int v) => new(0, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _yz(this Vector3Int v) => new(0, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _y_(this Vector3Int v) => new(0, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _zx(this Vector3Int v) => new(0, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _zy(this Vector3Int v) => new(0, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _zz(this Vector3Int v) => new(0, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int _z_(this Vector3Int v) => new(0, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int __x(this Vector3Int v) => new(0, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int __y(this Vector3Int v) => new(0, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3Int __z(this Vector3Int v) => new(0, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxxx(this Vector3Int v) => new(v.x, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxxy(this Vector3Int v) => new(v.x, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxxz(this Vector3Int v) => new(v.x, v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxx_(this Vector3Int v) => new(v.x, v.x, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxyx(this Vector3Int v) => new(v.x, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxyy(this Vector3Int v) => new(v.x, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxyz(this Vector3Int v) => new(v.x, v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxy_(this Vector3Int v) => new(v.x, v.x, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxzx(this Vector3Int v) => new(v.x, v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxzy(this Vector3Int v) => new(v.x, v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxzz(this Vector3Int v) => new(v.x, v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxz_(this Vector3Int v) => new(v.x, v.x, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx_x(this Vector3Int v) => new(v.x, v.x, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx_y(this Vector3Int v) => new(v.x, v.x, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx_z(this Vector3Int v) => new(v.x, v.x, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx__(this Vector3Int v) => new(v.x, v.x, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyxx(this Vector3Int v) => new(v.x, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyxy(this Vector3Int v) => new(v.x, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyxz(this Vector3Int v) => new(v.x, v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyx_(this Vector3Int v) => new(v.x, v.y, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyyx(this Vector3Int v) => new(v.x, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyyy(this Vector3Int v) => new(v.x, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyyz(this Vector3Int v) => new(v.x, v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyy_(this Vector3Int v) => new(v.x, v.y, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyzx(this Vector3Int v) => new(v.x, v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyzy(this Vector3Int v) => new(v.x, v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyzz(this Vector3Int v) => new(v.x, v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyz_(this Vector3Int v) => new(v.x, v.y, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy_x(this Vector3Int v) => new(v.x, v.y, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy_y(this Vector3Int v) => new(v.x, v.y, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy_z(this Vector3Int v) => new(v.x, v.y, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy__(this Vector3Int v) => new(v.x, v.y, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzxx(this Vector3Int v) => new(v.x, v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzxy(this Vector3Int v) => new(v.x, v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzxz(this Vector3Int v) => new(v.x, v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzx_(this Vector3Int v) => new(v.x, v.z, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzyx(this Vector3Int v) => new(v.x, v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzyy(this Vector3Int v) => new(v.x, v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzyz(this Vector3Int v) => new(v.x, v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzy_(this Vector3Int v) => new(v.x, v.z, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzzx(this Vector3Int v) => new(v.x, v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzzy(this Vector3Int v) => new(v.x, v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzzz(this Vector3Int v) => new(v.x, v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzz_(this Vector3Int v) => new(v.x, v.z, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xz_x(this Vector3Int v) => new(v.x, v.z, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xz_y(this Vector3Int v) => new(v.x, v.z, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xz_z(this Vector3Int v) => new(v.x, v.z, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xz__(this Vector3Int v) => new(v.x, v.z, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_xx(this Vector3Int v) => new(v.x, 0, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_xy(this Vector3Int v) => new(v.x, 0, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_xz(this Vector3Int v) => new(v.x, 0, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_x_(this Vector3Int v) => new(v.x, 0, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_yx(this Vector3Int v) => new(v.x, 0, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_yy(this Vector3Int v) => new(v.x, 0, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_yz(this Vector3Int v) => new(v.x, 0, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_y_(this Vector3Int v) => new(v.x, 0, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_zx(this Vector3Int v) => new(v.x, 0, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_zy(this Vector3Int v) => new(v.x, 0, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_zz(this Vector3Int v) => new(v.x, 0, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_z_(this Vector3Int v) => new(v.x, 0, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x__x(this Vector3Int v) => new(v.x, 0, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x__y(this Vector3Int v) => new(v.x, 0, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x__z(this Vector3Int v) => new(v.x, 0, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x___(this Vector3Int v) => new(v.x, 0, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxxx(this Vector3Int v) => new(v.y, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxxy(this Vector3Int v) => new(v.y, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxxz(this Vector3Int v) => new(v.y, v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxx_(this Vector3Int v) => new(v.y, v.x, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxyx(this Vector3Int v) => new(v.y, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxyy(this Vector3Int v) => new(v.y, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxyz(this Vector3Int v) => new(v.y, v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxy_(this Vector3Int v) => new(v.y, v.x, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxzx(this Vector3Int v) => new(v.y, v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxzy(this Vector3Int v) => new(v.y, v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxzz(this Vector3Int v) => new(v.y, v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxz_(this Vector3Int v) => new(v.y, v.x, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx_x(this Vector3Int v) => new(v.y, v.x, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx_y(this Vector3Int v) => new(v.y, v.x, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx_z(this Vector3Int v) => new(v.y, v.x, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx__(this Vector3Int v) => new(v.y, v.x, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyxx(this Vector3Int v) => new(v.y, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyxy(this Vector3Int v) => new(v.y, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyxz(this Vector3Int v) => new(v.y, v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyx_(this Vector3Int v) => new(v.y, v.y, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyyx(this Vector3Int v) => new(v.y, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyyy(this Vector3Int v) => new(v.y, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyyz(this Vector3Int v) => new(v.y, v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyy_(this Vector3Int v) => new(v.y, v.y, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyzx(this Vector3Int v) => new(v.y, v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyzy(this Vector3Int v) => new(v.y, v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyzz(this Vector3Int v) => new(v.y, v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyz_(this Vector3Int v) => new(v.y, v.y, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy_x(this Vector3Int v) => new(v.y, v.y, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy_y(this Vector3Int v) => new(v.y, v.y, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy_z(this Vector3Int v) => new(v.y, v.y, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy__(this Vector3Int v) => new(v.y, v.y, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzxx(this Vector3Int v) => new(v.y, v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzxy(this Vector3Int v) => new(v.y, v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzxz(this Vector3Int v) => new(v.y, v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzx_(this Vector3Int v) => new(v.y, v.z, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzyx(this Vector3Int v) => new(v.y, v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzyy(this Vector3Int v) => new(v.y, v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzyz(this Vector3Int v) => new(v.y, v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzy_(this Vector3Int v) => new(v.y, v.z, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzzx(this Vector3Int v) => new(v.y, v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzzy(this Vector3Int v) => new(v.y, v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzzz(this Vector3Int v) => new(v.y, v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzz_(this Vector3Int v) => new(v.y, v.z, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yz_x(this Vector3Int v) => new(v.y, v.z, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yz_y(this Vector3Int v) => new(v.y, v.z, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yz_z(this Vector3Int v) => new(v.y, v.z, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yz__(this Vector3Int v) => new(v.y, v.z, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_xx(this Vector3Int v) => new(v.y, 0, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_xy(this Vector3Int v) => new(v.y, 0, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_xz(this Vector3Int v) => new(v.y, 0, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_x_(this Vector3Int v) => new(v.y, 0, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_yx(this Vector3Int v) => new(v.y, 0, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_yy(this Vector3Int v) => new(v.y, 0, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_yz(this Vector3Int v) => new(v.y, 0, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_y_(this Vector3Int v) => new(v.y, 0, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_zx(this Vector3Int v) => new(v.y, 0, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_zy(this Vector3Int v) => new(v.y, 0, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_zz(this Vector3Int v) => new(v.y, 0, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_z_(this Vector3Int v) => new(v.y, 0, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y__x(this Vector3Int v) => new(v.y, 0, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y__y(this Vector3Int v) => new(v.y, 0, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y__z(this Vector3Int v) => new(v.y, 0, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y___(this Vector3Int v) => new(v.y, 0, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxxx(this Vector3Int v) => new(v.z, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxxy(this Vector3Int v) => new(v.z, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxxz(this Vector3Int v) => new(v.z, v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxx_(this Vector3Int v) => new(v.z, v.x, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxyx(this Vector3Int v) => new(v.z, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxyy(this Vector3Int v) => new(v.z, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxyz(this Vector3Int v) => new(v.z, v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxy_(this Vector3Int v) => new(v.z, v.x, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxzx(this Vector3Int v) => new(v.z, v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxzy(this Vector3Int v) => new(v.z, v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxzz(this Vector3Int v) => new(v.z, v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxz_(this Vector3Int v) => new(v.z, v.x, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zx_x(this Vector3Int v) => new(v.z, v.x, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zx_y(this Vector3Int v) => new(v.z, v.x, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zx_z(this Vector3Int v) => new(v.z, v.x, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zx__(this Vector3Int v) => new(v.z, v.x, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyxx(this Vector3Int v) => new(v.z, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyxy(this Vector3Int v) => new(v.z, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyxz(this Vector3Int v) => new(v.z, v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyx_(this Vector3Int v) => new(v.z, v.y, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyyx(this Vector3Int v) => new(v.z, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyyy(this Vector3Int v) => new(v.z, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyyz(this Vector3Int v) => new(v.z, v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyy_(this Vector3Int v) => new(v.z, v.y, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyzx(this Vector3Int v) => new(v.z, v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyzy(this Vector3Int v) => new(v.z, v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyzz(this Vector3Int v) => new(v.z, v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyz_(this Vector3Int v) => new(v.z, v.y, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zy_x(this Vector3Int v) => new(v.z, v.y, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zy_y(this Vector3Int v) => new(v.z, v.y, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zy_z(this Vector3Int v) => new(v.z, v.y, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zy__(this Vector3Int v) => new(v.z, v.y, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzxx(this Vector3Int v) => new(v.z, v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzxy(this Vector3Int v) => new(v.z, v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzxz(this Vector3Int v) => new(v.z, v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzx_(this Vector3Int v) => new(v.z, v.z, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzyx(this Vector3Int v) => new(v.z, v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzyy(this Vector3Int v) => new(v.z, v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzyz(this Vector3Int v) => new(v.z, v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzy_(this Vector3Int v) => new(v.z, v.z, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzzx(this Vector3Int v) => new(v.z, v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzzy(this Vector3Int v) => new(v.z, v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzzz(this Vector3Int v) => new(v.z, v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzz_(this Vector3Int v) => new(v.z, v.z, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zz_x(this Vector3Int v) => new(v.z, v.z, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zz_y(this Vector3Int v) => new(v.z, v.z, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zz_z(this Vector3Int v) => new(v.z, v.z, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zz__(this Vector3Int v) => new(v.z, v.z, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_xx(this Vector3Int v) => new(v.z, 0, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_xy(this Vector3Int v) => new(v.z, 0, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_xz(this Vector3Int v) => new(v.z, 0, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_x_(this Vector3Int v) => new(v.z, 0, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_yx(this Vector3Int v) => new(v.z, 0, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_yy(this Vector3Int v) => new(v.z, 0, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_yz(this Vector3Int v) => new(v.z, 0, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_y_(this Vector3Int v) => new(v.z, 0, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_zx(this Vector3Int v) => new(v.z, 0, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_zy(this Vector3Int v) => new(v.z, 0, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_zz(this Vector3Int v) => new(v.z, 0, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_z_(this Vector3Int v) => new(v.z, 0, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z__x(this Vector3Int v) => new(v.z, 0, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z__y(this Vector3Int v) => new(v.z, 0, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z__z(this Vector3Int v) => new(v.z, 0, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z___(this Vector3Int v) => new(v.z, 0, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xxx(this Vector3Int v) => new(0, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xxy(this Vector3Int v) => new(0, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xxz(this Vector3Int v) => new(0, v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xx_(this Vector3Int v) => new(0, v.x, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xyx(this Vector3Int v) => new(0, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xyy(this Vector3Int v) => new(0, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xyz(this Vector3Int v) => new(0, v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xy_(this Vector3Int v) => new(0, v.x, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xzx(this Vector3Int v) => new(0, v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xzy(this Vector3Int v) => new(0, v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xzz(this Vector3Int v) => new(0, v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xz_(this Vector3Int v) => new(0, v.x, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x_x(this Vector3Int v) => new(0, v.x, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x_y(this Vector3Int v) => new(0, v.x, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x_z(this Vector3Int v) => new(0, v.x, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x__(this Vector3Int v) => new(0, v.x, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yxx(this Vector3Int v) => new(0, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yxy(this Vector3Int v) => new(0, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yxz(this Vector3Int v) => new(0, v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yx_(this Vector3Int v) => new(0, v.y, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yyx(this Vector3Int v) => new(0, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yyy(this Vector3Int v) => new(0, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yyz(this Vector3Int v) => new(0, v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yy_(this Vector3Int v) => new(0, v.y, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yzx(this Vector3Int v) => new(0, v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yzy(this Vector3Int v) => new(0, v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yzz(this Vector3Int v) => new(0, v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yz_(this Vector3Int v) => new(0, v.y, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y_x(this Vector3Int v) => new(0, v.y, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y_y(this Vector3Int v) => new(0, v.y, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y_z(this Vector3Int v) => new(0, v.y, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y__(this Vector3Int v) => new(0, v.y, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zxx(this Vector3Int v) => new(0, v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zxy(this Vector3Int v) => new(0, v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zxz(this Vector3Int v) => new(0, v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zx_(this Vector3Int v) => new(0, v.z, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zyx(this Vector3Int v) => new(0, v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zyy(this Vector3Int v) => new(0, v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zyz(this Vector3Int v) => new(0, v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zy_(this Vector3Int v) => new(0, v.z, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zzx(this Vector3Int v) => new(0, v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zzy(this Vector3Int v) => new(0, v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zzz(this Vector3Int v) => new(0, v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zz_(this Vector3Int v) => new(0, v.z, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _z_x(this Vector3Int v) => new(0, v.z, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _z_y(this Vector3Int v) => new(0, v.z, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _z_z(this Vector3Int v) => new(0, v.z, 0, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _z__(this Vector3Int v) => new(0, v.z, 0, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __xx(this Vector3Int v) => new(0, 0, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __xy(this Vector3Int v) => new(0, 0, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __xz(this Vector3Int v) => new(0, 0, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __x_(this Vector3Int v) => new(0, 0, v.x, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __yx(this Vector3Int v) => new(0, 0, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __yy(this Vector3Int v) => new(0, 0, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __yz(this Vector3Int v) => new(0, 0, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __y_(this Vector3Int v) => new(0, 0, v.y, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __zx(this Vector3Int v) => new(0, 0, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __zy(this Vector3Int v) => new(0, 0, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __zz(this Vector3Int v) => new(0, 0, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __z_(this Vector3Int v) => new(0, 0, v.z, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ___x(this Vector3Int v) => new(0, 0, 0, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ___y(this Vector3Int v) => new(0, 0, 0, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ___z(this Vector3Int v) => new(0, 0, 0, v.z);

        #endregion

        #region SwizzleVector4
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 xx(this Vector4 v) => new(v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 xy(this Vector4 v) => new(v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 xz(this Vector4 v) => new(v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 xw(this Vector4 v) => new(v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 x_(this Vector4 v) => new(v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 yx(this Vector4 v) => new(v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 yy(this Vector4 v) => new(v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 yz(this Vector4 v) => new(v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 yw(this Vector4 v) => new(v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 y_(this Vector4 v) => new(v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 zx(this Vector4 v) => new(v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 zy(this Vector4 v) => new(v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 zz(this Vector4 v) => new(v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 zw(this Vector4 v) => new(v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 z_(this Vector4 v) => new(v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 wx(this Vector4 v) => new(v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 wy(this Vector4 v) => new(v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 wz(this Vector4 v) => new(v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 ww(this Vector4 v) => new(v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 w_(this Vector4 v) => new(v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 _x(this Vector4 v) => new(0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 _y(this Vector4 v) => new(0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 _z(this Vector4 v) => new(0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector2 _w(this Vector4 v) => new(0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xxx(this Vector4 v) => new(v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xxy(this Vector4 v) => new(v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xxz(this Vector4 v) => new(v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xxw(this Vector4 v) => new(v.x, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xx_(this Vector4 v) => new(v.x, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xyx(this Vector4 v) => new(v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xyy(this Vector4 v) => new(v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xyz(this Vector4 v) => new(v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xyw(this Vector4 v) => new(v.x, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xy_(this Vector4 v) => new(v.x, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xzx(this Vector4 v) => new(v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xzy(this Vector4 v) => new(v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xzz(this Vector4 v) => new(v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xzw(this Vector4 v) => new(v.x, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xz_(this Vector4 v) => new(v.x, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xwx(this Vector4 v) => new(v.x, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xwy(this Vector4 v) => new(v.x, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xwz(this Vector4 v) => new(v.x, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xww(this Vector4 v) => new(v.x, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 xw_(this Vector4 v) => new(v.x, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 x_x(this Vector4 v) => new(v.x, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 x_y(this Vector4 v) => new(v.x, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 x_z(this Vector4 v) => new(v.x, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 x_w(this Vector4 v) => new(v.x, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 x__(this Vector4 v) => new(v.x, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yxx(this Vector4 v) => new(v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yxy(this Vector4 v) => new(v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yxz(this Vector4 v) => new(v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yxw(this Vector4 v) => new(v.y, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yx_(this Vector4 v) => new(v.y, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yyx(this Vector4 v) => new(v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yyy(this Vector4 v) => new(v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yyz(this Vector4 v) => new(v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yyw(this Vector4 v) => new(v.y, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yy_(this Vector4 v) => new(v.y, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yzx(this Vector4 v) => new(v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yzy(this Vector4 v) => new(v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yzz(this Vector4 v) => new(v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yzw(this Vector4 v) => new(v.y, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yz_(this Vector4 v) => new(v.y, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 ywx(this Vector4 v) => new(v.y, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 ywy(this Vector4 v) => new(v.y, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 ywz(this Vector4 v) => new(v.y, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yww(this Vector4 v) => new(v.y, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 yw_(this Vector4 v) => new(v.y, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 y_x(this Vector4 v) => new(v.y, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 y_y(this Vector4 v) => new(v.y, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 y_z(this Vector4 v) => new(v.y, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 y_w(this Vector4 v) => new(v.y, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 y__(this Vector4 v) => new(v.y, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zxx(this Vector4 v) => new(v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zxy(this Vector4 v) => new(v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zxz(this Vector4 v) => new(v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zxw(this Vector4 v) => new(v.z, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zx_(this Vector4 v) => new(v.z, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zyx(this Vector4 v) => new(v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zyy(this Vector4 v) => new(v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zyz(this Vector4 v) => new(v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zyw(this Vector4 v) => new(v.z, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zy_(this Vector4 v) => new(v.z, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zzx(this Vector4 v) => new(v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zzy(this Vector4 v) => new(v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zzz(this Vector4 v) => new(v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zzw(this Vector4 v) => new(v.z, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zz_(this Vector4 v) => new(v.z, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zwx(this Vector4 v) => new(v.z, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zwy(this Vector4 v) => new(v.z, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zwz(this Vector4 v) => new(v.z, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zww(this Vector4 v) => new(v.z, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 zw_(this Vector4 v) => new(v.z, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 z_x(this Vector4 v) => new(v.z, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 z_y(this Vector4 v) => new(v.z, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 z_z(this Vector4 v) => new(v.z, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 z_w(this Vector4 v) => new(v.z, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 z__(this Vector4 v) => new(v.z, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wxx(this Vector4 v) => new(v.w, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wxy(this Vector4 v) => new(v.w, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wxz(this Vector4 v) => new(v.w, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wxw(this Vector4 v) => new(v.w, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wx_(this Vector4 v) => new(v.w, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wyx(this Vector4 v) => new(v.w, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wyy(this Vector4 v) => new(v.w, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wyz(this Vector4 v) => new(v.w, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wyw(this Vector4 v) => new(v.w, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wy_(this Vector4 v) => new(v.w, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wzx(this Vector4 v) => new(v.w, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wzy(this Vector4 v) => new(v.w, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wzz(this Vector4 v) => new(v.w, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wzw(this Vector4 v) => new(v.w, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wz_(this Vector4 v) => new(v.w, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wwx(this Vector4 v) => new(v.w, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wwy(this Vector4 v) => new(v.w, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 wwz(this Vector4 v) => new(v.w, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 www(this Vector4 v) => new(v.w, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 ww_(this Vector4 v) => new(v.w, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 w_x(this Vector4 v) => new(v.w, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 w_y(this Vector4 v) => new(v.w, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 w_z(this Vector4 v) => new(v.w, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 w_w(this Vector4 v) => new(v.w, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 w__(this Vector4 v) => new(v.w, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _xx(this Vector4 v) => new(0.0f, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _xy(this Vector4 v) => new(0.0f, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _xz(this Vector4 v) => new(0.0f, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _xw(this Vector4 v) => new(0.0f, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _x_(this Vector4 v) => new(0.0f, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _yx(this Vector4 v) => new(0.0f, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _yy(this Vector4 v) => new(0.0f, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _yz(this Vector4 v) => new(0.0f, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _yw(this Vector4 v) => new(0.0f, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _y_(this Vector4 v) => new(0.0f, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _zx(this Vector4 v) => new(0.0f, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _zy(this Vector4 v) => new(0.0f, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _zz(this Vector4 v) => new(0.0f, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _zw(this Vector4 v) => new(0.0f, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _z_(this Vector4 v) => new(0.0f, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _wx(this Vector4 v) => new(0.0f, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _wy(this Vector4 v) => new(0.0f, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _wz(this Vector4 v) => new(0.0f, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _ww(this Vector4 v) => new(0.0f, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 _w_(this Vector4 v) => new(0.0f, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 __x(this Vector4 v) => new(0.0f, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 __y(this Vector4 v) => new(0.0f, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 __z(this Vector4 v) => new(0.0f, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector3 __w(this Vector4 v) => new(0.0f, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxxx(this Vector4 v) => new(v.x, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxxy(this Vector4 v) => new(v.x, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxxz(this Vector4 v) => new(v.x, v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxxw(this Vector4 v) => new(v.x, v.x, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxx_(this Vector4 v) => new(v.x, v.x, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxyx(this Vector4 v) => new(v.x, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxyy(this Vector4 v) => new(v.x, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxyz(this Vector4 v) => new(v.x, v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxyw(this Vector4 v) => new(v.x, v.x, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxy_(this Vector4 v) => new(v.x, v.x, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxzx(this Vector4 v) => new(v.x, v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxzy(this Vector4 v) => new(v.x, v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxzz(this Vector4 v) => new(v.x, v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxzw(this Vector4 v) => new(v.x, v.x, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxz_(this Vector4 v) => new(v.x, v.x, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxwx(this Vector4 v) => new(v.x, v.x, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxwy(this Vector4 v) => new(v.x, v.x, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxwz(this Vector4 v) => new(v.x, v.x, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxww(this Vector4 v) => new(v.x, v.x, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xxw_(this Vector4 v) => new(v.x, v.x, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx_x(this Vector4 v) => new(v.x, v.x, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx_y(this Vector4 v) => new(v.x, v.x, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx_z(this Vector4 v) => new(v.x, v.x, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx_w(this Vector4 v) => new(v.x, v.x, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xx__(this Vector4 v) => new(v.x, v.x, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyxx(this Vector4 v) => new(v.x, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyxy(this Vector4 v) => new(v.x, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyxz(this Vector4 v) => new(v.x, v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyxw(this Vector4 v) => new(v.x, v.y, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyx_(this Vector4 v) => new(v.x, v.y, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyyx(this Vector4 v) => new(v.x, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyyy(this Vector4 v) => new(v.x, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyyz(this Vector4 v) => new(v.x, v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyyw(this Vector4 v) => new(v.x, v.y, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyy_(this Vector4 v) => new(v.x, v.y, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyzx(this Vector4 v) => new(v.x, v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyzy(this Vector4 v) => new(v.x, v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyzz(this Vector4 v) => new(v.x, v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyzw(this Vector4 v) => new(v.x, v.y, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyz_(this Vector4 v) => new(v.x, v.y, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xywx(this Vector4 v) => new(v.x, v.y, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xywy(this Vector4 v) => new(v.x, v.y, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xywz(this Vector4 v) => new(v.x, v.y, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyww(this Vector4 v) => new(v.x, v.y, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xyw_(this Vector4 v) => new(v.x, v.y, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy_x(this Vector4 v) => new(v.x, v.y, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy_y(this Vector4 v) => new(v.x, v.y, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy_z(this Vector4 v) => new(v.x, v.y, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy_w(this Vector4 v) => new(v.x, v.y, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xy__(this Vector4 v) => new(v.x, v.y, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzxx(this Vector4 v) => new(v.x, v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzxy(this Vector4 v) => new(v.x, v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzxz(this Vector4 v) => new(v.x, v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzxw(this Vector4 v) => new(v.x, v.z, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzx_(this Vector4 v) => new(v.x, v.z, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzyx(this Vector4 v) => new(v.x, v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzyy(this Vector4 v) => new(v.x, v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzyz(this Vector4 v) => new(v.x, v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzyw(this Vector4 v) => new(v.x, v.z, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzy_(this Vector4 v) => new(v.x, v.z, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzzx(this Vector4 v) => new(v.x, v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzzy(this Vector4 v) => new(v.x, v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzzz(this Vector4 v) => new(v.x, v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzzw(this Vector4 v) => new(v.x, v.z, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzz_(this Vector4 v) => new(v.x, v.z, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzwx(this Vector4 v) => new(v.x, v.z, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzwy(this Vector4 v) => new(v.x, v.z, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzwz(this Vector4 v) => new(v.x, v.z, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzww(this Vector4 v) => new(v.x, v.z, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xzw_(this Vector4 v) => new(v.x, v.z, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xz_x(this Vector4 v) => new(v.x, v.z, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xz_y(this Vector4 v) => new(v.x, v.z, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xz_z(this Vector4 v) => new(v.x, v.z, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xz_w(this Vector4 v) => new(v.x, v.z, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xz__(this Vector4 v) => new(v.x, v.z, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwxx(this Vector4 v) => new(v.x, v.w, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwxy(this Vector4 v) => new(v.x, v.w, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwxz(this Vector4 v) => new(v.x, v.w, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwxw(this Vector4 v) => new(v.x, v.w, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwx_(this Vector4 v) => new(v.x, v.w, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwyx(this Vector4 v) => new(v.x, v.w, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwyy(this Vector4 v) => new(v.x, v.w, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwyz(this Vector4 v) => new(v.x, v.w, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwyw(this Vector4 v) => new(v.x, v.w, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwy_(this Vector4 v) => new(v.x, v.w, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwzx(this Vector4 v) => new(v.x, v.w, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwzy(this Vector4 v) => new(v.x, v.w, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwzz(this Vector4 v) => new(v.x, v.w, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwzw(this Vector4 v) => new(v.x, v.w, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwz_(this Vector4 v) => new(v.x, v.w, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwwx(this Vector4 v) => new(v.x, v.w, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwwy(this Vector4 v) => new(v.x, v.w, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwwz(this Vector4 v) => new(v.x, v.w, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xwww(this Vector4 v) => new(v.x, v.w, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xww_(this Vector4 v) => new(v.x, v.w, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xw_x(this Vector4 v) => new(v.x, v.w, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xw_y(this Vector4 v) => new(v.x, v.w, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xw_z(this Vector4 v) => new(v.x, v.w, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xw_w(this Vector4 v) => new(v.x, v.w, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 xw__(this Vector4 v) => new(v.x, v.w, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_xx(this Vector4 v) => new(v.x, 0.0f, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_xy(this Vector4 v) => new(v.x, 0.0f, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_xz(this Vector4 v) => new(v.x, 0.0f, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_xw(this Vector4 v) => new(v.x, 0.0f, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_x_(this Vector4 v) => new(v.x, 0.0f, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_yx(this Vector4 v) => new(v.x, 0.0f, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_yy(this Vector4 v) => new(v.x, 0.0f, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_yz(this Vector4 v) => new(v.x, 0.0f, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_yw(this Vector4 v) => new(v.x, 0.0f, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_y_(this Vector4 v) => new(v.x, 0.0f, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_zx(this Vector4 v) => new(v.x, 0.0f, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_zy(this Vector4 v) => new(v.x, 0.0f, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_zz(this Vector4 v) => new(v.x, 0.0f, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_zw(this Vector4 v) => new(v.x, 0.0f, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_z_(this Vector4 v) => new(v.x, 0.0f, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_wx(this Vector4 v) => new(v.x, 0.0f, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_wy(this Vector4 v) => new(v.x, 0.0f, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_wz(this Vector4 v) => new(v.x, 0.0f, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_ww(this Vector4 v) => new(v.x, 0.0f, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x_w_(this Vector4 v) => new(v.x, 0.0f, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x__x(this Vector4 v) => new(v.x, 0.0f, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x__y(this Vector4 v) => new(v.x, 0.0f, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x__z(this Vector4 v) => new(v.x, 0.0f, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x__w(this Vector4 v) => new(v.x, 0.0f, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 x___(this Vector4 v) => new(v.x, 0.0f, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxxx(this Vector4 v) => new(v.y, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxxy(this Vector4 v) => new(v.y, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxxz(this Vector4 v) => new(v.y, v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxxw(this Vector4 v) => new(v.y, v.x, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxx_(this Vector4 v) => new(v.y, v.x, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxyx(this Vector4 v) => new(v.y, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxyy(this Vector4 v) => new(v.y, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxyz(this Vector4 v) => new(v.y, v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxyw(this Vector4 v) => new(v.y, v.x, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxy_(this Vector4 v) => new(v.y, v.x, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxzx(this Vector4 v) => new(v.y, v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxzy(this Vector4 v) => new(v.y, v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxzz(this Vector4 v) => new(v.y, v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxzw(this Vector4 v) => new(v.y, v.x, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxz_(this Vector4 v) => new(v.y, v.x, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxwx(this Vector4 v) => new(v.y, v.x, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxwy(this Vector4 v) => new(v.y, v.x, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxwz(this Vector4 v) => new(v.y, v.x, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxww(this Vector4 v) => new(v.y, v.x, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yxw_(this Vector4 v) => new(v.y, v.x, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx_x(this Vector4 v) => new(v.y, v.x, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx_y(this Vector4 v) => new(v.y, v.x, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx_z(this Vector4 v) => new(v.y, v.x, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx_w(this Vector4 v) => new(v.y, v.x, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yx__(this Vector4 v) => new(v.y, v.x, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyxx(this Vector4 v) => new(v.y, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyxy(this Vector4 v) => new(v.y, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyxz(this Vector4 v) => new(v.y, v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyxw(this Vector4 v) => new(v.y, v.y, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyx_(this Vector4 v) => new(v.y, v.y, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyyx(this Vector4 v) => new(v.y, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyyy(this Vector4 v) => new(v.y, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyyz(this Vector4 v) => new(v.y, v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyyw(this Vector4 v) => new(v.y, v.y, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyy_(this Vector4 v) => new(v.y, v.y, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyzx(this Vector4 v) => new(v.y, v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyzy(this Vector4 v) => new(v.y, v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyzz(this Vector4 v) => new(v.y, v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyzw(this Vector4 v) => new(v.y, v.y, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyz_(this Vector4 v) => new(v.y, v.y, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yywx(this Vector4 v) => new(v.y, v.y, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yywy(this Vector4 v) => new(v.y, v.y, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yywz(this Vector4 v) => new(v.y, v.y, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyww(this Vector4 v) => new(v.y, v.y, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yyw_(this Vector4 v) => new(v.y, v.y, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy_x(this Vector4 v) => new(v.y, v.y, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy_y(this Vector4 v) => new(v.y, v.y, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy_z(this Vector4 v) => new(v.y, v.y, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy_w(this Vector4 v) => new(v.y, v.y, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yy__(this Vector4 v) => new(v.y, v.y, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzxx(this Vector4 v) => new(v.y, v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzxy(this Vector4 v) => new(v.y, v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzxz(this Vector4 v) => new(v.y, v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzxw(this Vector4 v) => new(v.y, v.z, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzx_(this Vector4 v) => new(v.y, v.z, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzyx(this Vector4 v) => new(v.y, v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzyy(this Vector4 v) => new(v.y, v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzyz(this Vector4 v) => new(v.y, v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzyw(this Vector4 v) => new(v.y, v.z, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzy_(this Vector4 v) => new(v.y, v.z, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzzx(this Vector4 v) => new(v.y, v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzzy(this Vector4 v) => new(v.y, v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzzz(this Vector4 v) => new(v.y, v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzzw(this Vector4 v) => new(v.y, v.z, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzz_(this Vector4 v) => new(v.y, v.z, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzwx(this Vector4 v) => new(v.y, v.z, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzwy(this Vector4 v) => new(v.y, v.z, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzwz(this Vector4 v) => new(v.y, v.z, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzww(this Vector4 v) => new(v.y, v.z, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yzw_(this Vector4 v) => new(v.y, v.z, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yz_x(this Vector4 v) => new(v.y, v.z, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yz_y(this Vector4 v) => new(v.y, v.z, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yz_z(this Vector4 v) => new(v.y, v.z, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yz_w(this Vector4 v) => new(v.y, v.z, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yz__(this Vector4 v) => new(v.y, v.z, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywxx(this Vector4 v) => new(v.y, v.w, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywxy(this Vector4 v) => new(v.y, v.w, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywxz(this Vector4 v) => new(v.y, v.w, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywxw(this Vector4 v) => new(v.y, v.w, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywx_(this Vector4 v) => new(v.y, v.w, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywyx(this Vector4 v) => new(v.y, v.w, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywyy(this Vector4 v) => new(v.y, v.w, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywyz(this Vector4 v) => new(v.y, v.w, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywyw(this Vector4 v) => new(v.y, v.w, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywy_(this Vector4 v) => new(v.y, v.w, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywzx(this Vector4 v) => new(v.y, v.w, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywzy(this Vector4 v) => new(v.y, v.w, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywzz(this Vector4 v) => new(v.y, v.w, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywzw(this Vector4 v) => new(v.y, v.w, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywz_(this Vector4 v) => new(v.y, v.w, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywwx(this Vector4 v) => new(v.y, v.w, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywwy(this Vector4 v) => new(v.y, v.w, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywwz(this Vector4 v) => new(v.y, v.w, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ywww(this Vector4 v) => new(v.y, v.w, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yww_(this Vector4 v) => new(v.y, v.w, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yw_x(this Vector4 v) => new(v.y, v.w, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yw_y(this Vector4 v) => new(v.y, v.w, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yw_z(this Vector4 v) => new(v.y, v.w, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yw_w(this Vector4 v) => new(v.y, v.w, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 yw__(this Vector4 v) => new(v.y, v.w, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_xx(this Vector4 v) => new(v.y, 0.0f, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_xy(this Vector4 v) => new(v.y, 0.0f, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_xz(this Vector4 v) => new(v.y, 0.0f, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_xw(this Vector4 v) => new(v.y, 0.0f, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_x_(this Vector4 v) => new(v.y, 0.0f, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_yx(this Vector4 v) => new(v.y, 0.0f, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_yy(this Vector4 v) => new(v.y, 0.0f, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_yz(this Vector4 v) => new(v.y, 0.0f, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_yw(this Vector4 v) => new(v.y, 0.0f, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_y_(this Vector4 v) => new(v.y, 0.0f, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_zx(this Vector4 v) => new(v.y, 0.0f, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_zy(this Vector4 v) => new(v.y, 0.0f, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_zz(this Vector4 v) => new(v.y, 0.0f, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_zw(this Vector4 v) => new(v.y, 0.0f, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_z_(this Vector4 v) => new(v.y, 0.0f, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_wx(this Vector4 v) => new(v.y, 0.0f, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_wy(this Vector4 v) => new(v.y, 0.0f, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_wz(this Vector4 v) => new(v.y, 0.0f, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_ww(this Vector4 v) => new(v.y, 0.0f, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y_w_(this Vector4 v) => new(v.y, 0.0f, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y__x(this Vector4 v) => new(v.y, 0.0f, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y__y(this Vector4 v) => new(v.y, 0.0f, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y__z(this Vector4 v) => new(v.y, 0.0f, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y__w(this Vector4 v) => new(v.y, 0.0f, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 y___(this Vector4 v) => new(v.y, 0.0f, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxxx(this Vector4 v) => new(v.z, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxxy(this Vector4 v) => new(v.z, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxxz(this Vector4 v) => new(v.z, v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxxw(this Vector4 v) => new(v.z, v.x, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxx_(this Vector4 v) => new(v.z, v.x, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxyx(this Vector4 v) => new(v.z, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxyy(this Vector4 v) => new(v.z, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxyz(this Vector4 v) => new(v.z, v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxyw(this Vector4 v) => new(v.z, v.x, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxy_(this Vector4 v) => new(v.z, v.x, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxzx(this Vector4 v) => new(v.z, v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxzy(this Vector4 v) => new(v.z, v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxzz(this Vector4 v) => new(v.z, v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxzw(this Vector4 v) => new(v.z, v.x, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxz_(this Vector4 v) => new(v.z, v.x, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxwx(this Vector4 v) => new(v.z, v.x, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxwy(this Vector4 v) => new(v.z, v.x, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxwz(this Vector4 v) => new(v.z, v.x, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxww(this Vector4 v) => new(v.z, v.x, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zxw_(this Vector4 v) => new(v.z, v.x, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zx_x(this Vector4 v) => new(v.z, v.x, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zx_y(this Vector4 v) => new(v.z, v.x, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zx_z(this Vector4 v) => new(v.z, v.x, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zx_w(this Vector4 v) => new(v.z, v.x, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zx__(this Vector4 v) => new(v.z, v.x, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyxx(this Vector4 v) => new(v.z, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyxy(this Vector4 v) => new(v.z, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyxz(this Vector4 v) => new(v.z, v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyxw(this Vector4 v) => new(v.z, v.y, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyx_(this Vector4 v) => new(v.z, v.y, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyyx(this Vector4 v) => new(v.z, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyyy(this Vector4 v) => new(v.z, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyyz(this Vector4 v) => new(v.z, v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyyw(this Vector4 v) => new(v.z, v.y, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyy_(this Vector4 v) => new(v.z, v.y, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyzx(this Vector4 v) => new(v.z, v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyzy(this Vector4 v) => new(v.z, v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyzz(this Vector4 v) => new(v.z, v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyzw(this Vector4 v) => new(v.z, v.y, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyz_(this Vector4 v) => new(v.z, v.y, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zywx(this Vector4 v) => new(v.z, v.y, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zywy(this Vector4 v) => new(v.z, v.y, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zywz(this Vector4 v) => new(v.z, v.y, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyww(this Vector4 v) => new(v.z, v.y, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zyw_(this Vector4 v) => new(v.z, v.y, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zy_x(this Vector4 v) => new(v.z, v.y, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zy_y(this Vector4 v) => new(v.z, v.y, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zy_z(this Vector4 v) => new(v.z, v.y, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zy_w(this Vector4 v) => new(v.z, v.y, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zy__(this Vector4 v) => new(v.z, v.y, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzxx(this Vector4 v) => new(v.z, v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzxy(this Vector4 v) => new(v.z, v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzxz(this Vector4 v) => new(v.z, v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzxw(this Vector4 v) => new(v.z, v.z, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzx_(this Vector4 v) => new(v.z, v.z, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzyx(this Vector4 v) => new(v.z, v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzyy(this Vector4 v) => new(v.z, v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzyz(this Vector4 v) => new(v.z, v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzyw(this Vector4 v) => new(v.z, v.z, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzy_(this Vector4 v) => new(v.z, v.z, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzzx(this Vector4 v) => new(v.z, v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzzy(this Vector4 v) => new(v.z, v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzzz(this Vector4 v) => new(v.z, v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzzw(this Vector4 v) => new(v.z, v.z, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzz_(this Vector4 v) => new(v.z, v.z, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzwx(this Vector4 v) => new(v.z, v.z, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzwy(this Vector4 v) => new(v.z, v.z, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzwz(this Vector4 v) => new(v.z, v.z, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzww(this Vector4 v) => new(v.z, v.z, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zzw_(this Vector4 v) => new(v.z, v.z, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zz_x(this Vector4 v) => new(v.z, v.z, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zz_y(this Vector4 v) => new(v.z, v.z, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zz_z(this Vector4 v) => new(v.z, v.z, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zz_w(this Vector4 v) => new(v.z, v.z, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zz__(this Vector4 v) => new(v.z, v.z, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwxx(this Vector4 v) => new(v.z, v.w, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwxy(this Vector4 v) => new(v.z, v.w, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwxz(this Vector4 v) => new(v.z, v.w, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwxw(this Vector4 v) => new(v.z, v.w, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwx_(this Vector4 v) => new(v.z, v.w, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwyx(this Vector4 v) => new(v.z, v.w, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwyy(this Vector4 v) => new(v.z, v.w, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwyz(this Vector4 v) => new(v.z, v.w, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwyw(this Vector4 v) => new(v.z, v.w, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwy_(this Vector4 v) => new(v.z, v.w, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwzx(this Vector4 v) => new(v.z, v.w, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwzy(this Vector4 v) => new(v.z, v.w, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwzz(this Vector4 v) => new(v.z, v.w, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwzw(this Vector4 v) => new(v.z, v.w, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwz_(this Vector4 v) => new(v.z, v.w, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwwx(this Vector4 v) => new(v.z, v.w, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwwy(this Vector4 v) => new(v.z, v.w, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwwz(this Vector4 v) => new(v.z, v.w, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zwww(this Vector4 v) => new(v.z, v.w, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zww_(this Vector4 v) => new(v.z, v.w, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zw_x(this Vector4 v) => new(v.z, v.w, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zw_y(this Vector4 v) => new(v.z, v.w, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zw_z(this Vector4 v) => new(v.z, v.w, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zw_w(this Vector4 v) => new(v.z, v.w, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 zw__(this Vector4 v) => new(v.z, v.w, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_xx(this Vector4 v) => new(v.z, 0.0f, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_xy(this Vector4 v) => new(v.z, 0.0f, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_xz(this Vector4 v) => new(v.z, 0.0f, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_xw(this Vector4 v) => new(v.z, 0.0f, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_x_(this Vector4 v) => new(v.z, 0.0f, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_yx(this Vector4 v) => new(v.z, 0.0f, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_yy(this Vector4 v) => new(v.z, 0.0f, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_yz(this Vector4 v) => new(v.z, 0.0f, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_yw(this Vector4 v) => new(v.z, 0.0f, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_y_(this Vector4 v) => new(v.z, 0.0f, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_zx(this Vector4 v) => new(v.z, 0.0f, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_zy(this Vector4 v) => new(v.z, 0.0f, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_zz(this Vector4 v) => new(v.z, 0.0f, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_zw(this Vector4 v) => new(v.z, 0.0f, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_z_(this Vector4 v) => new(v.z, 0.0f, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_wx(this Vector4 v) => new(v.z, 0.0f, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_wy(this Vector4 v) => new(v.z, 0.0f, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_wz(this Vector4 v) => new(v.z, 0.0f, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_ww(this Vector4 v) => new(v.z, 0.0f, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z_w_(this Vector4 v) => new(v.z, 0.0f, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z__x(this Vector4 v) => new(v.z, 0.0f, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z__y(this Vector4 v) => new(v.z, 0.0f, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z__z(this Vector4 v) => new(v.z, 0.0f, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z__w(this Vector4 v) => new(v.z, 0.0f, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 z___(this Vector4 v) => new(v.z, 0.0f, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxxx(this Vector4 v) => new(v.w, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxxy(this Vector4 v) => new(v.w, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxxz(this Vector4 v) => new(v.w, v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxxw(this Vector4 v) => new(v.w, v.x, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxx_(this Vector4 v) => new(v.w, v.x, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxyx(this Vector4 v) => new(v.w, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxyy(this Vector4 v) => new(v.w, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxyz(this Vector4 v) => new(v.w, v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxyw(this Vector4 v) => new(v.w, v.x, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxy_(this Vector4 v) => new(v.w, v.x, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxzx(this Vector4 v) => new(v.w, v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxzy(this Vector4 v) => new(v.w, v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxzz(this Vector4 v) => new(v.w, v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxzw(this Vector4 v) => new(v.w, v.x, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxz_(this Vector4 v) => new(v.w, v.x, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxwx(this Vector4 v) => new(v.w, v.x, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxwy(this Vector4 v) => new(v.w, v.x, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxwz(this Vector4 v) => new(v.w, v.x, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxww(this Vector4 v) => new(v.w, v.x, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wxw_(this Vector4 v) => new(v.w, v.x, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wx_x(this Vector4 v) => new(v.w, v.x, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wx_y(this Vector4 v) => new(v.w, v.x, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wx_z(this Vector4 v) => new(v.w, v.x, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wx_w(this Vector4 v) => new(v.w, v.x, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wx__(this Vector4 v) => new(v.w, v.x, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyxx(this Vector4 v) => new(v.w, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyxy(this Vector4 v) => new(v.w, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyxz(this Vector4 v) => new(v.w, v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyxw(this Vector4 v) => new(v.w, v.y, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyx_(this Vector4 v) => new(v.w, v.y, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyyx(this Vector4 v) => new(v.w, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyyy(this Vector4 v) => new(v.w, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyyz(this Vector4 v) => new(v.w, v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyyw(this Vector4 v) => new(v.w, v.y, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyy_(this Vector4 v) => new(v.w, v.y, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyzx(this Vector4 v) => new(v.w, v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyzy(this Vector4 v) => new(v.w, v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyzz(this Vector4 v) => new(v.w, v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyzw(this Vector4 v) => new(v.w, v.y, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyz_(this Vector4 v) => new(v.w, v.y, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wywx(this Vector4 v) => new(v.w, v.y, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wywy(this Vector4 v) => new(v.w, v.y, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wywz(this Vector4 v) => new(v.w, v.y, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyww(this Vector4 v) => new(v.w, v.y, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wyw_(this Vector4 v) => new(v.w, v.y, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wy_x(this Vector4 v) => new(v.w, v.y, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wy_y(this Vector4 v) => new(v.w, v.y, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wy_z(this Vector4 v) => new(v.w, v.y, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wy_w(this Vector4 v) => new(v.w, v.y, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wy__(this Vector4 v) => new(v.w, v.y, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzxx(this Vector4 v) => new(v.w, v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzxy(this Vector4 v) => new(v.w, v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzxz(this Vector4 v) => new(v.w, v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzxw(this Vector4 v) => new(v.w, v.z, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzx_(this Vector4 v) => new(v.w, v.z, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzyx(this Vector4 v) => new(v.w, v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzyy(this Vector4 v) => new(v.w, v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzyz(this Vector4 v) => new(v.w, v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzyw(this Vector4 v) => new(v.w, v.z, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzy_(this Vector4 v) => new(v.w, v.z, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzzx(this Vector4 v) => new(v.w, v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzzy(this Vector4 v) => new(v.w, v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzzz(this Vector4 v) => new(v.w, v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzzw(this Vector4 v) => new(v.w, v.z, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzz_(this Vector4 v) => new(v.w, v.z, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzwx(this Vector4 v) => new(v.w, v.z, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzwy(this Vector4 v) => new(v.w, v.z, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzwz(this Vector4 v) => new(v.w, v.z, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzww(this Vector4 v) => new(v.w, v.z, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wzw_(this Vector4 v) => new(v.w, v.z, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wz_x(this Vector4 v) => new(v.w, v.z, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wz_y(this Vector4 v) => new(v.w, v.z, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wz_z(this Vector4 v) => new(v.w, v.z, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wz_w(this Vector4 v) => new(v.w, v.z, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wz__(this Vector4 v) => new(v.w, v.z, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwxx(this Vector4 v) => new(v.w, v.w, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwxy(this Vector4 v) => new(v.w, v.w, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwxz(this Vector4 v) => new(v.w, v.w, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwxw(this Vector4 v) => new(v.w, v.w, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwx_(this Vector4 v) => new(v.w, v.w, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwyx(this Vector4 v) => new(v.w, v.w, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwyy(this Vector4 v) => new(v.w, v.w, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwyz(this Vector4 v) => new(v.w, v.w, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwyw(this Vector4 v) => new(v.w, v.w, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwy_(this Vector4 v) => new(v.w, v.w, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwzx(this Vector4 v) => new(v.w, v.w, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwzy(this Vector4 v) => new(v.w, v.w, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwzz(this Vector4 v) => new(v.w, v.w, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwzw(this Vector4 v) => new(v.w, v.w, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwz_(this Vector4 v) => new(v.w, v.w, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwwx(this Vector4 v) => new(v.w, v.w, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwwy(this Vector4 v) => new(v.w, v.w, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwwz(this Vector4 v) => new(v.w, v.w, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 wwww(this Vector4 v) => new(v.w, v.w, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 www_(this Vector4 v) => new(v.w, v.w, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ww_x(this Vector4 v) => new(v.w, v.w, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ww_y(this Vector4 v) => new(v.w, v.w, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ww_z(this Vector4 v) => new(v.w, v.w, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ww_w(this Vector4 v) => new(v.w, v.w, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ww__(this Vector4 v) => new(v.w, v.w, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_xx(this Vector4 v) => new(v.w, 0.0f, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_xy(this Vector4 v) => new(v.w, 0.0f, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_xz(this Vector4 v) => new(v.w, 0.0f, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_xw(this Vector4 v) => new(v.w, 0.0f, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_x_(this Vector4 v) => new(v.w, 0.0f, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_yx(this Vector4 v) => new(v.w, 0.0f, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_yy(this Vector4 v) => new(v.w, 0.0f, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_yz(this Vector4 v) => new(v.w, 0.0f, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_yw(this Vector4 v) => new(v.w, 0.0f, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_y_(this Vector4 v) => new(v.w, 0.0f, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_zx(this Vector4 v) => new(v.w, 0.0f, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_zy(this Vector4 v) => new(v.w, 0.0f, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_zz(this Vector4 v) => new(v.w, 0.0f, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_zw(this Vector4 v) => new(v.w, 0.0f, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_z_(this Vector4 v) => new(v.w, 0.0f, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_wx(this Vector4 v) => new(v.w, 0.0f, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_wy(this Vector4 v) => new(v.w, 0.0f, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_wz(this Vector4 v) => new(v.w, 0.0f, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_ww(this Vector4 v) => new(v.w, 0.0f, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w_w_(this Vector4 v) => new(v.w, 0.0f, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w__x(this Vector4 v) => new(v.w, 0.0f, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w__y(this Vector4 v) => new(v.w, 0.0f, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w__z(this Vector4 v) => new(v.w, 0.0f, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w__w(this Vector4 v) => new(v.w, 0.0f, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 w___(this Vector4 v) => new(v.w, 0.0f, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xxx(this Vector4 v) => new(0.0f, v.x, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xxy(this Vector4 v) => new(0.0f, v.x, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xxz(this Vector4 v) => new(0.0f, v.x, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xxw(this Vector4 v) => new(0.0f, v.x, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xx_(this Vector4 v) => new(0.0f, v.x, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xyx(this Vector4 v) => new(0.0f, v.x, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xyy(this Vector4 v) => new(0.0f, v.x, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xyz(this Vector4 v) => new(0.0f, v.x, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xyw(this Vector4 v) => new(0.0f, v.x, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xy_(this Vector4 v) => new(0.0f, v.x, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xzx(this Vector4 v) => new(0.0f, v.x, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xzy(this Vector4 v) => new(0.0f, v.x, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xzz(this Vector4 v) => new(0.0f, v.x, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xzw(this Vector4 v) => new(0.0f, v.x, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xz_(this Vector4 v) => new(0.0f, v.x, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xwx(this Vector4 v) => new(0.0f, v.x, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xwy(this Vector4 v) => new(0.0f, v.x, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xwz(this Vector4 v) => new(0.0f, v.x, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xww(this Vector4 v) => new(0.0f, v.x, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _xw_(this Vector4 v) => new(0.0f, v.x, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x_x(this Vector4 v) => new(0.0f, v.x, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x_y(this Vector4 v) => new(0.0f, v.x, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x_z(this Vector4 v) => new(0.0f, v.x, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x_w(this Vector4 v) => new(0.0f, v.x, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _x__(this Vector4 v) => new(0.0f, v.x, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yxx(this Vector4 v) => new(0.0f, v.y, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yxy(this Vector4 v) => new(0.0f, v.y, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yxz(this Vector4 v) => new(0.0f, v.y, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yxw(this Vector4 v) => new(0.0f, v.y, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yx_(this Vector4 v) => new(0.0f, v.y, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yyx(this Vector4 v) => new(0.0f, v.y, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yyy(this Vector4 v) => new(0.0f, v.y, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yyz(this Vector4 v) => new(0.0f, v.y, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yyw(this Vector4 v) => new(0.0f, v.y, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yy_(this Vector4 v) => new(0.0f, v.y, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yzx(this Vector4 v) => new(0.0f, v.y, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yzy(this Vector4 v) => new(0.0f, v.y, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yzz(this Vector4 v) => new(0.0f, v.y, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yzw(this Vector4 v) => new(0.0f, v.y, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yz_(this Vector4 v) => new(0.0f, v.y, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _ywx(this Vector4 v) => new(0.0f, v.y, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _ywy(this Vector4 v) => new(0.0f, v.y, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _ywz(this Vector4 v) => new(0.0f, v.y, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yww(this Vector4 v) => new(0.0f, v.y, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _yw_(this Vector4 v) => new(0.0f, v.y, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y_x(this Vector4 v) => new(0.0f, v.y, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y_y(this Vector4 v) => new(0.0f, v.y, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y_z(this Vector4 v) => new(0.0f, v.y, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y_w(this Vector4 v) => new(0.0f, v.y, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _y__(this Vector4 v) => new(0.0f, v.y, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zxx(this Vector4 v) => new(0.0f, v.z, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zxy(this Vector4 v) => new(0.0f, v.z, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zxz(this Vector4 v) => new(0.0f, v.z, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zxw(this Vector4 v) => new(0.0f, v.z, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zx_(this Vector4 v) => new(0.0f, v.z, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zyx(this Vector4 v) => new(0.0f, v.z, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zyy(this Vector4 v) => new(0.0f, v.z, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zyz(this Vector4 v) => new(0.0f, v.z, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zyw(this Vector4 v) => new(0.0f, v.z, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zy_(this Vector4 v) => new(0.0f, v.z, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zzx(this Vector4 v) => new(0.0f, v.z, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zzy(this Vector4 v) => new(0.0f, v.z, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zzz(this Vector4 v) => new(0.0f, v.z, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zzw(this Vector4 v) => new(0.0f, v.z, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zz_(this Vector4 v) => new(0.0f, v.z, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zwx(this Vector4 v) => new(0.0f, v.z, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zwy(this Vector4 v) => new(0.0f, v.z, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zwz(this Vector4 v) => new(0.0f, v.z, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zww(this Vector4 v) => new(0.0f, v.z, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _zw_(this Vector4 v) => new(0.0f, v.z, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _z_x(this Vector4 v) => new(0.0f, v.z, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _z_y(this Vector4 v) => new(0.0f, v.z, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _z_z(this Vector4 v) => new(0.0f, v.z, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _z_w(this Vector4 v) => new(0.0f, v.z, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _z__(this Vector4 v) => new(0.0f, v.z, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wxx(this Vector4 v) => new(0.0f, v.w, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wxy(this Vector4 v) => new(0.0f, v.w, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wxz(this Vector4 v) => new(0.0f, v.w, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wxw(this Vector4 v) => new(0.0f, v.w, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wx_(this Vector4 v) => new(0.0f, v.w, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wyx(this Vector4 v) => new(0.0f, v.w, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wyy(this Vector4 v) => new(0.0f, v.w, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wyz(this Vector4 v) => new(0.0f, v.w, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wyw(this Vector4 v) => new(0.0f, v.w, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wy_(this Vector4 v) => new(0.0f, v.w, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wzx(this Vector4 v) => new(0.0f, v.w, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wzy(this Vector4 v) => new(0.0f, v.w, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wzz(this Vector4 v) => new(0.0f, v.w, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wzw(this Vector4 v) => new(0.0f, v.w, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wz_(this Vector4 v) => new(0.0f, v.w, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wwx(this Vector4 v) => new(0.0f, v.w, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wwy(this Vector4 v) => new(0.0f, v.w, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _wwz(this Vector4 v) => new(0.0f, v.w, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _www(this Vector4 v) => new(0.0f, v.w, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _ww_(this Vector4 v) => new(0.0f, v.w, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _w_x(this Vector4 v) => new(0.0f, v.w, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _w_y(this Vector4 v) => new(0.0f, v.w, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _w_z(this Vector4 v) => new(0.0f, v.w, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _w_w(this Vector4 v) => new(0.0f, v.w, 0.0f, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 _w__(this Vector4 v) => new(0.0f, v.w, 0.0f, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __xx(this Vector4 v) => new(0.0f, 0.0f, v.x, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __xy(this Vector4 v) => new(0.0f, 0.0f, v.x, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __xz(this Vector4 v) => new(0.0f, 0.0f, v.x, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __xw(this Vector4 v) => new(0.0f, 0.0f, v.x, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __x_(this Vector4 v) => new(0.0f, 0.0f, v.x, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __yx(this Vector4 v) => new(0.0f, 0.0f, v.y, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __yy(this Vector4 v) => new(0.0f, 0.0f, v.y, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __yz(this Vector4 v) => new(0.0f, 0.0f, v.y, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __yw(this Vector4 v) => new(0.0f, 0.0f, v.y, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __y_(this Vector4 v) => new(0.0f, 0.0f, v.y, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __zx(this Vector4 v) => new(0.0f, 0.0f, v.z, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __zy(this Vector4 v) => new(0.0f, 0.0f, v.z, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __zz(this Vector4 v) => new(0.0f, 0.0f, v.z, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __zw(this Vector4 v) => new(0.0f, 0.0f, v.z, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __z_(this Vector4 v) => new(0.0f, 0.0f, v.z, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __wx(this Vector4 v) => new(0.0f, 0.0f, v.w, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __wy(this Vector4 v) => new(0.0f, 0.0f, v.w, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __wz(this Vector4 v) => new(0.0f, 0.0f, v.w, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __ww(this Vector4 v) => new(0.0f, 0.0f, v.w, v.w);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 __w_(this Vector4 v) => new(0.0f, 0.0f, v.w, 0.0f);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ___x(this Vector4 v) => new(0.0f, 0.0f, 0.0f, v.x);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ___y(this Vector4 v) => new(0.0f, 0.0f, 0.0f, v.y);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ___z(this Vector4 v) => new(0.0f, 0.0f, 0.0f, v.z);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Vector4 ___w(this Vector4 v) => new(0.0f, 0.0f, 0.0f, v.w);
        #endregion
    }
}
