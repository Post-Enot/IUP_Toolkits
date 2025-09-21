using System;
using UnityEngine;

namespace IUP.Toolkits
{
    public static class IUP_Math
    {
        public static class Safe
        {
            public static long Mul(int a, int b) => (long)a * b;

            public static ulong Mul(uint a, uint b) => (ulong)a * b;

            public static long Sum(int a, int b) => (long)a + b;

            public static long Sum(uint a, uint b) => (long)a + b;

            public static long Diff(int a, int b) => (long)a - b;

            public static long Diff(uint a, uint b) => (long)a - b;

            public static bool IsNegationSafe(sbyte a) => a != sbyte.MinValue;

            public static bool IsNegationSafe(short a) => a != short.MinValue;

            public static bool IsNegationSafe(int a) => a != int.MinValue;

            public static bool IsNegationSafe(long a) => a != long.MinValue;

            public static int Abs(short a) => a >= 0 ? a : -a;

            public static long Abs(int a) => a >= 0 ? a : -(long)a;

            public static uint AbsUnsigned(int a) => a >= 0 ? (uint)a : (uint)unchecked(-a);

            public static ulong AbsUnsigned(long a) => a >= 0L ? (ulong)a : (ulong)unchecked(-a);

            public static long Pow2(int a) => (long)a * a;
        }

        public const float PI = MathF.PI;
        public const float PI2 = MathF.PI * 2.0f;
        public const float PI2Inverse = 1.0f / PI2;

        #region Min
        /// <summary>
        /// Возвращает меньшее из двух 8-битных целых чисел со знаком.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наименьшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static sbyte Min(sbyte a, sbyte b) => Math.Min(a, b);

        /// <summary>
        /// Возвращает меньшее из двух 8-битных целых чисел без знака.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наименьшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static byte Min(byte a, byte b) => Math.Min(a, b);

        /// <summary>
        /// Возвращает меньшее из двух 16-битных целых чисел со знаком.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наименьшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static short Min(short a, short b) => Math.Min(a, b);

        /// <summary>
        /// Возвращает меньшее из двух 16-битных целых чисел без знака.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наименьшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static ushort Min(ushort a, ushort b) => Math.Min(a, b);

        /// <summary>
        /// Возвращает меньшее из двух 32-битных целых чисел со знаком.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наименьшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static int Min(int a, int b) => Math.Min(a, b);

        /// <summary>
        /// Возвращает меньшее из двух 32-битных целых чисел без знака.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наименьшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static uint Min(uint a, uint b) => Math.Min(a, b);

        /// <summary>
        /// Возвращает меньшее из двух 64-битных целых чисел со знаком.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наименьшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static long Min(long a, long b) => Math.Min(a, b);

        /// <summary>
        /// Возвращает меньшее из двух 64-битных целых чисел без знака.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наименьшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static ulong Min(ulong a, ulong b) => Math.Min(a, b);

        /// <summary>
        /// Возвращает меньшее из двух чисел одинарной точности.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>
        /// Наименьшее из <paramref name="a"/> и <paramref name="b"/>.<br/>
        /// Если <paramref name="a"/>, <paramref name="b"/> или оба параметра равны <see cref="float.NaN"/>,
        /// возвращается значение <see cref="float.NaN"/>.
        /// </returns>
        public static float Min(float a, float b) => MathF.Min(a, b);

        /// <summary>
        /// Возвращает меньшее из двух чисел двойной точности.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>
        /// Наименьшее из <paramref name="a"/> и <paramref name="b"/>.<br/>
        /// Если <paramref name="a"/>, <paramref name="b"/> или оба параметра равны <see cref="double.NaN"/>,
        /// возвращается значение <see cref="double.NaN"/>.
        /// </returns>
        public static double Min(double a, double b) => Math.Min(a, b);

        /// <summary>
        /// Возвращает меньшее из двух десятичных.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наименьшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static decimal Min(decimal a, decimal b) => Math.Min(a, b);

        /// <summary>
        /// Возвращает минимальную компоненту вектора.
        /// </summary>
        /// <param name="a">Исходный вектор.</param>
        /// <returns>Минимальное значение среди компонент вектора.</returns>
        public static float Min(Vector2 a) => Math.Min(a.x, a.y);

        /// <summary>
        /// Возвращает минимальную компоненту вектора.
        /// </summary>
        /// <param name="a">Исходный вектор.</param>
        /// <returns>Минимальное значение среди компонент вектора.</returns>
        public static float Min(Vector3 a)
        {
            float maxXY = Math.Min(a.x, a.y);
            return Math.Min(maxXY, a.z);
        }

        /// <summary>
        /// Возвращает минимальную компоненту вектора.
        /// </summary>
        /// <param name="a">Исходный вектор.</param>
        /// <returns>Минимальное значение среди компонент вектора.</returns>
        public static float Min(Vector4 a)
        {
            float max = Math.Min(a.x, a.y);
            max = Math.Min(max, a.z);
            return Math.Min(max, a.w);
        }

        /// <summary>
        /// Возвращает минимальную компоненту вектора.
        /// </summary>
        /// <param name="a">Исходный вектор.</param>
        /// <returns>Минимальное значение среди компонент вектора.</returns>
        public static int Min(Vector2Int a) => Math.Min(a.x, a.y);

        /// <summary>
        /// Возвращает минимальную компоненту вектора.
        /// </summary>
        /// <param name="a">Исходный вектор.</param>
        /// <returns>Минимальное значение среди компонент вектора.</returns>
        public static int Min(Vector3Int a)
        {
            int min = Math.Min(a.x, a.y);
            return Math.Min(min, a.z);
        }
        #endregion

        #region Max
        /// <summary>
        /// Возвращает большее из двух 8-битных целых чисел со знаком.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наибольшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static sbyte Max(sbyte a, sbyte b) => Math.Max(a, b);

        /// <summary>
        /// Возвращает большее из двух 8-битных целых чисел без знака.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наибольшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static byte Max(byte a, byte b) => Math.Max(a, b);

        /// <summary>
        /// Возвращает большее из двух 16-битных целых чисел со знаком.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наибольшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static short Max(short a, short b) => Math.Max(a, b);

        /// <summary>
        /// Возвращает большее из двух 16-битных целых чисел без знака.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наибольшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static ushort Max(ushort a, ushort b) => Math.Max(a, b);

        /// <summary>
        /// Возвращает большее из двух 32-битных целых чисел со знаком.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наибольшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static int Max(int a, int b) => Math.Max(a, b);

        /// <summary>
        /// Возвращает большее из двух 32-битных целых чисел без знака.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наибольшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static uint Max(uint a, uint b) => Math.Max(a, b);

        /// <summary>
        /// Возвращает большее из двух 64-битных целых чисел со знаком.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наибольшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static long Max(long a, long b) => Math.Max(a, b);

        /// <summary>
        /// Возвращает большее из двух 64-битных целых чисел без знака.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наибольшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static ulong Max(ulong a, ulong b) => Math.Max(a, b);

        /// <summary>
        /// Возвращает большее из двух чисел одинарной точности.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>
        /// Наибольшее из <paramref name="a"/> и <paramref name="b"/>.<br/>
        /// Если <paramref name="a"/>, <paramref name="b"/> или оба параметра равны <see cref="float.NaN"/>,
        /// возвращается значение <see cref="float.NaN"/>.
        /// </returns>
        public static float Max(float a, float b) => MathF.Max(a, b);

        /// <summary>
        /// Возвращает большее из двух чисел двойной точности.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>
        /// Наибольшее из <paramref name="a"/> и <paramref name="b"/>.<br/>
        /// Если <paramref name="a"/>, <paramref name="b"/> или оба параметра равны <see cref="double.NaN"/>,
        /// возвращается значение <see cref="double.NaN"/>.
        /// </returns>
        public static double Max(double a, double b) => Math.Max(a, b);

        /// <summary>
        /// Возвращает большее из двух десятичных чисел.
        /// </summary>
        /// <param name="a">Первое сравниваемое число.</param>
        /// <param name="b">Второе сравниваемое число.</param>
        /// <returns>Наибольшее из <paramref name="a"/> и <paramref name="b"/>.</returns>
        public static decimal Max(decimal a, decimal b) => Math.Max(a, b);

        /// <summary>
        /// Возвращает максимальную компоненту вектора.
        /// </summary>
        /// <param name="a">Исходный вектор.</param>
        /// <returns>Максимальное значение среди компонент вектора.</returns>
        public static float Max(Vector2 a) => Math.Max(a.x, a.y);

        /// <summary>
        /// Возвращает максимальную компоненту вектора.
        /// </summary>
        /// <param name="a">Исходный вектор.</param>
        /// <returns>Максимальное значение среди компонент вектора.</returns>
        public static float Max(Vector3 a)
        {
            float max = Math.Max(a.x, a.y);
            return Math.Max(max, a.z);
        }

        /// <summary>
        /// Возвращает максимальную компоненту вектора.
        /// </summary>
        /// <param name="a">Исходный вектор.</param>
        /// <returns>Максимальное значение среди компонент вектора.</returns>
        public static float Max(Vector4 a)
        {
            float max = Math.Max(a.x, a.y);
            max = Math.Max(max, a.z);
            return Math.Max(max, a.w);
        }

        /// <summary>
        /// Возвращает максимальную компоненту вектора.
        /// </summary>
        /// <param name="a">Исходный вектор.</param>
        /// <returns>Максимальное значение среди компонент вектора.</returns>
        public static int Max(Vector2Int a) => Math.Max(a.x, a.y);

        /// <summary>
        /// Возвращает максимальную компоненту вектора.
        /// </summary>
        /// <param name="a">Исходный вектор.</param>
        /// <returns>Максимальное значение среди компонент вектора.</returns>
        public static int Max(Vector3Int a)
        {
            int max = Math.Max(a.x, a.y);
            return Math.Max(max, a.z);
        }
        #endregion

        #region Max0
        /// <summary>
        /// Возвращает максимальное значение между 8-битным целым числом со знаком и 0.
        /// </summary>
        /// <param name="a">Сравниваемое число.</param>
        /// <returns>
        /// <paramref name="a"/>, если <paramref name="a"/> больше 0; иначе 0.
        /// </returns>
        public static sbyte Max0(sbyte a) => Math.Max(a, (sbyte)0);

        /// <summary>
        /// Возвращает максимальное значение между 16-битным целым числом со знаком и 0.
        /// </summary>
        /// <param name="a">Сравниваемое число.</param>
        /// <returns>
        /// <paramref name="a"/>, если <paramref name="a"/> больше 0; иначе 0.
        /// </returns>
        public static short Max0(short a) => Math.Max(a, (short)0);

        /// <summary>
        /// Возвращает максимальное значение между 32-битным целым числом со знаком и 0.
        /// </summary>
        /// <param name="a">Сравниваемое число.</param>
        /// <returns>
        /// <paramref name="a"/>, если <paramref name="a"/> больше 0; иначе 0.
        /// </returns>
        public static int Max0(int a) => Math.Max(a, 0);

        /// <summary>
        /// Возвращает максимальное значение между 64-битным целым числом со знаком и 0.
        /// </summary>
        /// <param name="a">Сравниваемое число.</param>
        /// <returns>
        /// <paramref name="a"/>, если <paramref name="a"/> больше 0; иначе 0.
        /// </returns>
        public static long Max0(long a) => Math.Max(a, 0L);

        /// <summary>
        /// Возвращает максимальное значение между числом одинарной точности и 0.
        /// </summary>
        /// <param name="a">Сравниваемое число.</param>
        /// <returns>
        /// <paramref name="a"/>, если <paramref name="a"/> больше 0; иначе 0.
        /// Если <paramref name="a"/> равен <see cref="float.NaN"/>, возвращается <see cref="float.NaN"/>.
        /// </returns>
        public static float Max0(float a) => MathF.Max(a, 0.0f);

        /// <summary>
        /// Возвращает максимальное значение между числом двойной точности и 0.
        /// </summary>
        /// <param name="a">Сравниваемое число.</param>
        /// <returns>
        /// <paramref name="a"/>, если <paramref name="a"/> больше 0; иначе 0.
        /// Если <paramref name="a"/> равно <see cref="double.NaN"/>, возвращается <see cref="double.NaN"/>.
        /// </returns>
        public static double Max0(double a) => Math.Max(a, 0.0);

        /// <summary>
        /// Возвращает максимальное значение между десятичным числом и 0.
        /// </summary>
        /// <param name="a">Сравниваемое число.</param>
        /// <returns>
        /// <paramref name="a"/>, если <paramref name="a"/> больше 0; иначе 0.
        /// </returns>
        public static decimal Max0(decimal a) => Math.Max(a, 0.0M);
        #endregion

        #region Clamp
        /// <summary>
        /// Возвращает значение 8-битного целого числа со знаком, ограниченное указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// <paramref name="min"/>, если <paramref name="value"/> меньше <paramref name="min"/>;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static sbyte Clamp(sbyte value, sbyte min, sbyte max) => Math.Clamp(value, min, max);

        /// <summary>
        /// Возвращает значение 8-битного целого числа без знака, ограниченное указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// <paramref name="min"/>, если <paramref name="value"/> меньше <paramref name="min"/>;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static byte Clamp(byte value, byte min, byte max) => Math.Clamp(value, min, max);

        /// <summary>
        /// Возвращает значение 16-битного целого числа со знаком, ограниченное указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// <paramref name="min"/>, если <paramref name="value"/> меньше <paramref name="min"/>;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static short Clamp(short value, short min, short max) => Math.Clamp(value, min, max);

        /// <summary>
        /// Возвращает значение 16-битного целого числа без знака, ограниченное указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// <paramref name="min"/>, если <paramref name="value"/> меньше <paramref name="min"/>;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static ushort Clamp(ushort value, ushort min, ushort max) => Math.Clamp(value, min, max);

        /// <summary>
        /// Возвращает значение 32-битного целого числа, ограниченное указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// <paramref name="min"/>, если <paramref name="value"/> меньше <paramref name="min"/>;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static int Clamp(int value, int min, int max) => Math.Clamp(value, min, max);

        /// <summary>
        /// Возвращает значение 32-битного целого числа без знака, ограниченное указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// <paramref name="min"/>, если <paramref name="value"/> меньше <paramref name="min"/>;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static uint Clamp(uint value, uint min, uint max) => Math.Clamp(value, min, max);

        /// <summary>
        /// Возвращает значение 64-битного целого числа, ограниченное указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// <paramref name="min"/>, если <paramref name="value"/> меньше <paramref name="min"/>;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static long Clamp(long value, long min, long max) => Math.Clamp(value, min, max);

        /// <summary>
        /// Возвращает значение 64-битного целого числа без знака, ограниченное указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// <paramref name="min"/>, если <paramref name="value"/> меньше <paramref name="min"/>;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static ulong Clamp(ulong value, ulong min, ulong max) => Math.Clamp(value, min, max);

        /// <summary>
        /// Возвращает число одинарной точности, ограниченное указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// <paramref name="min"/>, если <paramref name="value"/> меньше <paramref name="min"/>;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.<br/>
        /// Если любой из параметров (<paramref name="value"/>, <paramref name="min"/>, <paramref name="max"/>) равен 
        /// <see cref="float.NaN"/>, возвращается <see cref="float.NaN"/>.
        /// </returns>
        public static float Clamp(float value, float min, float max) => Math.Clamp(value, min, max);

        /// <summary>
        /// Возвращает число двойной точности, ограниченное указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// <paramref name="min"/>, если <paramref name="value"/> меньше <paramref name="min"/>;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.<br/>
        /// Если любой из параметров (<paramref name="value"/>, <paramref name="min"/>, <paramref name="max"/>) равен 
        /// <see cref="double.NaN"/>, возвращается <see cref="double.NaN"/>.
        /// </returns>
        public static double Clamp(double value, double min, double max) => Math.Clamp(value, min, max);

        /// <summary>
        /// Возвращает десятичное число, ограниченное указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// <paramref name="min"/>, если <paramref name="value"/> меньше <paramref name="min"/>;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static decimal Clamp(decimal value, decimal min, decimal max) => Math.Clamp(value, min, max);

        /// <summary>
        /// Возвращает вектор, компоненты которого ограничены указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемый вектор.</param>
        /// <param name="min">Нижняя граница диапазона (вектор).</param>
        /// <param name="max">Верхняя граница диапазона (вектор).</param>
        /// <returns>
        /// Вектор, каждая компонента которого ограничена соответствующими компонентами
        /// <paramref name="min"/> и <paramref name="max"/>.
        /// </returns>
        public static Vector2 Clamp(Vector2 value, Vector2 min, Vector2 max)
        {
            float x = Clamp(value.x, min.x, max.x);
            float y = Clamp(value.y, min.y, max.y);
            return new Vector2(x, y);
        }

        /// <summary>
        /// Возвращает вектор, компоненты которого ограничены указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемый вектор.</param>
        /// <param name="min">Нижняя граница диапазона (вектор).</param>
        /// <param name="max">Верхняя граница диапазона (вектор).</param>
        /// <returns>
        /// Вектор, каждая компонента которого ограничена соответствующими компонентами
        /// <paramref name="min"/> и <paramref name="max"/>.
        /// </returns>
        public static Vector3 Clamp(Vector3 value, Vector3 min, Vector3 max)
        {
            float x = Clamp(value.x, min.x, max.x);
            float y = Clamp(value.y, min.y, max.y);
            float z = Clamp(value.z, min.z, max.z);
            return new Vector3(x, y, z);
        }

        /// <summary>
        /// Возвращает вектор, компоненты которого ограничены указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемый вектор.</param>
        /// <param name="min">Нижняя граница диапазона (вектор).</param>
        /// <param name="max">Верхняя граница диапазона (вектор).</param>
        /// <returns>
        /// Вектор, каждая компонента которого ограничена соответствующими компонентами
        /// <paramref name="min"/> и <paramref name="max"/>.
        /// </returns>
        public static Vector4 Clamp(Vector4 value, Vector4 min, Vector4 max)
        {
            float x = Clamp(value.x, min.x, max.x);
            float y = Clamp(value.y, min.y, max.y);
            float z = Clamp(value.z, min.z, max.z);
            float w = Clamp(value.w, min.w, max.w);
            return new Vector4(x, y, z, w);
        }

        /// <summary>
        /// Возвращает целочисленный вектор, компоненты которого ограничены указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемый вектор.</param>
        /// <param name="min">Нижняя граница диапазона (вектор).</param>
        /// <param name="max">Верхняя граница диапазона (вектор).</param>
        /// <returns>
        /// Вектор, каждая компонента которого ограничена соответствующими компонентами
        /// <paramref name="min"/> и <paramref name="max"/>.
        /// </returns>
        public static Vector2Int Clamp(Vector2Int value, Vector2Int min, Vector2Int max)
        {
            int x = Clamp(value.x, min.x, max.x);
            int y = Clamp(value.y, min.y, max.y);
            return new Vector2Int(x, y);
        }

        /// <summary>
        /// Возвращает целочисленный вектор, компоненты которого ограничены указанным диапазоном.
        /// </summary>
        /// <param name="value">Ограничиваемый вектор.</param>
        /// <param name="min">Нижняя граница диапазона (вектор).</param>
        /// <param name="max">Верхняя граница диапазона (вектор).</param>
        /// <returns>
        /// Вектор, каждая компонента которого ограничена соответствующими компонентами
        /// <paramref name="min"/> и <paramref name="max"/>.
        /// </returns>
        public static Vector3Int Clamp(Vector3Int value, Vector3Int min, Vector3Int max)
        {
            int x = Clamp(value.x, min.x, max.x);
            int y = Clamp(value.y, min.y, max.y);
            int z = Clamp(value.z, min.z, max.z);
            return new Vector3Int(x, y, z);
        }
        #endregion

        #region Clamp0
        /// <summary>
        /// Возвращает значение 8-битного целого числа со знаком, ограниченное диапазоном
        /// [0, <paramref name="max"/>].
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// 0, если <paramref name="value"/> меньше 0;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static sbyte Clamp0(sbyte value, sbyte max) => Math.Clamp(value, (sbyte)0, max);

        /// <summary>
        /// Возвращает значение 16-битного целого числа со знаком, ограниченное диапазоном
        /// [0, <paramref name="max"/>].
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// 0, если <paramref name="value"/> меньше 0;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static short Clamp0(short value, short max) => Math.Clamp(value, (short)0, max);

        /// <summary>
        /// Возвращает значение 32-битного целого числа, ограниченное диапазоном
        /// [0, <paramref name="max"/>].
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// 0, если <paramref name="value"/> меньше 0;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static int Clamp0(int value, int max) => Math.Clamp(value, 0, max);

        /// <summary>
        /// Возвращает значение 64-битного целого числа, ограниченное диапазоном
        /// [0, <paramref name="max"/>].
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// 0, если <paramref name="value"/> меньше 0;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static long Clamp0(long value, long max) => Math.Clamp(value, 0, max);

        /// <summary>
        /// Возвращает число одинарной точности, ограниченное диапазоном
        /// [0, <paramref name="max"/>].
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// 0, если <paramref name="value"/> меньше 0;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.<br/>
        /// Если любой из параметров (<paramref name="value"/>, <paramref name="max"/>) равен 
        /// <see cref="float.NaN"/>, возвращается <see cref="float.NaN"/>.
        /// </returns>
        public static float Clamp0(float value, float max) => Math.Clamp(value, 0.0f, max);

        /// <summary>
        /// Возвращает число двойной точности, ограниченное диапазоном [0, <paramref name="max"/>].
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// 0, если <paramref name="value"/> меньше 0;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.<br/>
        /// Если любой из параметров (<paramref name="value"/>, <paramref name="max"/>) равен 
        /// <see cref="double.NaN"/>, возвращается <see cref="double.NaN"/>.
        /// </returns>
        public static double Clamp0(double value, double max) => Math.Clamp(value, 0.0D, max);

        /// <summary>
        /// Возвращает десятичное число, ограниченное диапазоном [0, <paramref name="max"/>].
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <returns>
        /// 0, если <paramref name="value"/> меньше 0;<br/>
        /// <paramref name="max"/>, если <paramref name="value"/> больше <paramref name="max"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static decimal Clamp0(decimal value, decimal max) => Math.Clamp(value, 0.0M, max);
        #endregion

        #region Clamp01

        /// <summary>
        /// Возвращает число одинарной точности, ограниченное диапазоном [0, 1].
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// 0, если <paramref name="value"/> меньше 0;<br/>
        /// 1, если <paramref name="value"/> больше 1;<br/>
        /// иначе <paramref name="value"/>.<br/>
        /// Если <paramref name="value"/> равно <see cref="float.NaN"/>, возвращается <see cref="float.NaN"/>.
        /// </returns>
        public static float Clamp01(float value) => Math.Clamp(value, 0.0f, 1.0f);

        /// <summary>
        /// Возвращает число двойной точности, ограниченное диапазоном [0, 1].
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// 0, если <paramref name="value"/> меньше 0;<br/>
        /// 1, если <paramref name="value"/> больше 1;<br/>
        /// иначе <paramref name="value"/>.<br/>
        /// Если <paramref name="value"/> равно <see cref="double.NaN"/>, возвращается <see cref="double.NaN"/>.
        /// </returns>
        public static double Clamp01(double value) => Math.Clamp(value, 0.0D, 1.0D);

        /// <summary>
        /// Возвращает десятичное число, ограниченное диапазоном [0, 1].
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// 0, если <paramref name="value"/> меньше 0;<br/>
        /// 1, если <paramref name="value"/> больше 1;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static decimal Clamp01(decimal value) => Math.Clamp(value, 0.0M, 1.0M);

        #endregion

        #region Clamp11

        /// <summary>
        /// Возвращает число одинарной точности, ограниченное диапазоном [-1, 1].
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// -1, если <paramref name="value"/> меньше -1;<br/>
        /// 1, если <paramref name="value"/> больше 1;<br/>
        /// иначе <paramref name="value"/>.<br/>
        /// Если <paramref name="value"/> равно <see cref="float.NaN"/>, возвращается <see cref="float.NaN"/>.
        /// </returns>
        public static float Clamp11(float value) => Math.Clamp(value, -1.0f, 1.0f);

        /// <summary>
        /// Возвращает число двойной точности, ограниченное диапазоном [-1, 1].
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// -1, если <paramref name="value"/> меньше -1;<br/>
        /// 1, если <paramref name="value"/> больше 1;<br/>
        /// иначе <paramref name="value"/>.<br/>
        /// Если <paramref name="value"/> равно <see cref="double.NaN"/>, возвращается <see cref="double.NaN"/>.
        /// </returns>
        public static double Clamp11(double value) => Math.Clamp(value, -1.0D, 1.0D);

        /// <summary>
        /// Возвращает десятичное число, ограниченное диапазоном [-1, 1].
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// -1, если <paramref name="value"/> меньше -1;<br/>
        /// 1, если <paramref name="value"/> больше 1;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static decimal Clamp11(decimal value) => Math.Clamp(value, -1.0M, 1.0M);

        #endregion

        #region ClampToUInt8

        /// <summary>
        /// Ограничивает 32-битное целое число со знаком до диапазона 8-битного целого числа без знака.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="byte.MinValue"/>, если <paramref name="value"/> меньше <see cref="byte.MinValue"/>;<br/>
        /// <see cref="byte.MaxValue"/>, если <paramref name="value"/> больше <see cref="byte.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static byte ClampToUInt8(int value) => value switch
        {
            > byte.MaxValue => byte.MaxValue,
            < byte.MinValue => byte.MinValue,
            _ => (byte)value
        };

        /// <summary>
        /// Ограничивает 32-битное целое число без знака до диапазона 8-битного целого числа без знака.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="byte.MaxValue"/>, если <paramref name="value"/> больше <see cref="byte.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static byte ClampToUInt8(uint value)
            => value > byte.MaxValue ? byte.MaxValue : (byte)value;

        /// <summary>
        /// Ограничивает 64-битное целое число со знаком до диапазона 8-битного целого числа без знака.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="byte.MinValue"/>, если <paramref name="value"/> меньше <see cref="byte.MinValue"/>;<br/>
        /// <see cref="byte.MaxValue"/>, если <paramref name="value"/> больше <see cref="byte.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static byte ClampToUInt8(long value) => value switch
        {
            > byte.MaxValue => byte.MaxValue,
            < byte.MinValue => byte.MinValue,
            _ => (byte)value
        };

        /// <summary>
        /// Ограничивает 64-битное целое число без знака до диапазона 8-битного целого числа без знака.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="byte.MaxValue"/>, если <paramref name="value"/> больше <see cref="byte.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static byte ClampToUInt8(ulong value)
            => value > byte.MaxValue ? byte.MaxValue : (byte)value;

        #endregion

        #region ClampToInt8

        /// <summary>
        /// Ограничивает 32-битное целое число со знаком до диапазона 8-битного целого числа со знаком.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="sbyte.MinValue"/>, если <paramref name="value"/> меньше <see cref="sbyte.MinValue"/>;<br/>
        /// <see cref="sbyte.MaxValue"/>, если <paramref name="value"/> больше <see cref="sbyte.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static sbyte ClampToInt8(int value) => value switch
        {
            > sbyte.MaxValue => sbyte.MaxValue,
            < sbyte.MinValue => sbyte.MinValue,
            _ => (sbyte)value
        };

        /// <summary>
        /// Ограничивает 32-битное целое число без знака до диапазона 8-битного целого числа со знаком.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="sbyte.MaxValue"/>, если <paramref name="value"/> больше <see cref="sbyte.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static sbyte ClampToInt8(uint value) => value > 127U ? sbyte.MaxValue : (sbyte)value;

        /// <summary>
        /// Ограничивает 64-битное целое число со знаком до диапазона 8-битного целого числа со знаком.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="sbyte.MinValue"/>, если <paramref name="value"/> меньше <see cref="sbyte.MinValue"/>;<br/>
        /// <see cref="sbyte.MaxValue"/>, если <paramref name="value"/> больше <see cref="sbyte.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static sbyte ClampToInt8(long value) => value switch
        {
            > sbyte.MaxValue => sbyte.MaxValue,
            < sbyte.MinValue => sbyte.MinValue,
            _ => (sbyte)value
        };

        /// <summary>
        /// Ограничивает 64-битное целое число без знака до диапазона 8-битного целого числа со знаком.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="sbyte.MaxValue"/>, если <paramref name="value"/> больше <see cref="sbyte.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static sbyte ClampToInt8(ulong value)
            => value > (ulong)sbyte.MaxValue ? sbyte.MaxValue : (sbyte)value;

        #endregion

        #region ClampToUInt16

        /// <summary>
        /// Ограничивает 32-битное целое число со знаком до диапазона 16-битного целого числа без знака.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="ushort.MinValue"/>, если <paramref name="value"/> меньше <see cref="ushort.MinValue"/>;<br/>
        /// <see cref="ushort.MaxValue"/>, если <paramref name="value"/> больше <see cref="ushort.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static ushort ClampToUInt16(int value) => value switch
        {
            > ushort.MaxValue => ushort.MaxValue,
            < ushort.MinValue => ushort.MinValue,
            _ => (ushort)value
        };

        /// <summary>
        /// Ограничивает 32-битное целое число без знака до диапазона 16-битного целого числа без знака.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="ushort.MaxValue"/>, если <paramref name="value"/> больше <see cref="ushort.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static ushort ClampToUInt16(uint value)
            => value > ushort.MaxValue ? ushort.MaxValue : (ushort)value;

        /// <summary>
        /// Ограничивает 64-битное целое число со знаком до диапазона 16-битного целого числа без знака.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="ushort.MinValue"/>, если <paramref name="value"/> меньше <see cref="ushort.MinValue"/>;<br/>
        /// <see cref="ushort.MaxValue"/>, если <paramref name="value"/> больше <see cref="ushort.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static ushort ClampToUInt16(long value) => value switch
        {
            > ushort.MaxValue => ushort.MaxValue,
            < ushort.MinValue => ushort.MinValue,
            _ => (ushort)value
        };

        /// <summary>
        /// Ограничивает 64-битное целое число без знака до диапазона 16-битного целого числа без знака.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="ushort.MaxValue"/>, если <paramref name="value"/> больше <see cref="ushort.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static ushort ClampToUInt16(ulong value)
            => value > ushort.MaxValue ? ushort.MaxValue : (ushort)value;

        #endregion

        #region ClampToInt16

        /// <summary>
        /// Ограничивает 32-битное целое число со знаком до диапазона 16-битного целого числа со знаком.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="short.MinValue"/>, если <paramref name="value"/> меньше <see cref="short.MinValue"/>;<br/>
        /// <see cref="short.MaxValue"/>, если <paramref name="value"/> больше <see cref="short.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static short ClampToInt16(int value) => value switch
        {
            > short.MaxValue => short.MaxValue,
            < short.MinValue => short.MinValue,
            _ => (short)value
        };

        /// <summary>
        /// Ограничивает 32-битное целое число без знака до диапазона 16-битного целого числа со знаком.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="short.MaxValue"/>, если <paramref name="value"/> больше <see cref="short.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static short ClampToInt16(uint value) => value > short.MaxValue ? short.MaxValue : (short)value;

        /// <summary>
        /// Ограничивает 64-битное целое число со знаком до диапазона 16-битного целого числа со знаком.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="short.MinValue"/>, если <paramref name="value"/> меньше <see cref="short.MinValue"/>;<br/>
        /// <see cref="short.MaxValue"/>, если <paramref name="value"/> больше <see cref="short.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static short ClampToInt16(long value) => value switch
        {
            > short.MaxValue => short.MaxValue,
            < short.MinValue => short.MinValue,
            _ => (short)value
        };

        /// <summary>
        /// Ограничивает 64-битное целое число без знака до диапазона 16-битного целого числа со знаком.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="short.MaxValue"/>, если <paramref name="value"/> больше <see cref="short.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static short ClampToInt16(ulong value)
            => value > (ulong)short.MaxValue ? short.MaxValue : (short)value;

        #endregion

        #region ClampToInt32

        /// <summary>
        /// Ограничивает 32-битное целое число без знака до диапазона 32-битного целого числа со знаком.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="int.MaxValue"/>, если <paramref name="value"/> больше <see cref="int.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static int ClampToInt32(uint value)
            => value > int.MaxValue ? int.MaxValue : (int)value;

        /// <summary>
        /// Ограничивает 64-битное целое число со знаком до диапазона 32-битного целого числа со знаком.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="int.MinValue"/>, если <paramref name="value"/> меньше <see cref="int.MinValue"/>;<br/>
        /// <see cref="int.MaxValue"/>, если <paramref name="value"/> больше <see cref="int.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static int ClampToInt32(long value) => value switch
        {
            > int.MaxValue => int.MaxValue,
            < int.MinValue => int.MinValue,
            _ => (int)value
        };

        /// <summary>
        /// Ограничивает 64-битное целое число без знака до диапазона 32-битного целого числа со знаком.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="int.MaxValue"/>, если <paramref name="value"/> больше <see cref="int.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static int ClampToInt32(ulong value)
            => value > int.MaxValue ? int.MaxValue : (int)value;

        #endregion

        #region ClampToUInt32

        /// <summary>
        /// Ограничивает 32-битное целое число со знаком до диапазона 32-битного целого числа без знака.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="uint.MinValue"/>, если <paramref name="value"/> меньше <see cref="uint.MinValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static uint ClampToUInt32(int value) => value < 0 ? uint.MinValue : (uint)value;

        /// <summary>
        /// Ограничивает 64-битное целое число без знака до диапазона 32-битного целого числа без знака.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="uint.MinValue"/>, если <paramref name="value"/> меньше <see cref="uint.MinValue"/>;<br/>
        /// <see cref="uint.MaxValue"/>, если <paramref name="value"/> больше <see cref="uint.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static uint ClampToUInt32(long value) => value switch
        {
            > uint.MaxValue => uint.MaxValue,
            < uint.MinValue => uint.MinValue,
            _ => (uint)value
        };

        /// <summary>
        /// Ограничивает 64-битное целое число без знака до диапазона 32-битного целого числа без знака.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="uint.MaxValue"/>, если <paramref name="value"/> больше <see cref="uint.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static uint ClampToUInt32(ulong value)
            => value > uint.MaxValue ? uint.MaxValue : (uint)value;

        #endregion

        #region ClampToInt64

        /// <summary>
        /// Ограничивает 64-битное целое число без знака до диапазона 64-битного целого числа со знаком.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="long.MaxValue"/>, если <paramref name="value"/> больше <see cref="long.MaxValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static long ClampToInt64(ulong value)
            => value > long.MaxValue ? long.MaxValue : (long)value;

        #endregion

        #region ClampToUInt64

        /// <summary>
        /// Ограничивает 64-битное целое число со знаком до диапазона 64-битного целого числа без знака.
        /// </summary>
        /// <param name="value">Ограничиваемое значение.</param>
        /// <returns>
        /// <see cref="ulong.MinValue"/>, если <paramref name="value"/> меньше <see cref="ulong.MinValue"/>;<br/>
        /// иначе <paramref name="value"/>.
        /// </returns>
        public static ulong ClampToUInt64(long value)
            => value < 0L ? ulong.MinValue : (ulong)value;

        #endregion

        #region Lerp
        public static float Lerp(float a, float b, float t) => a + (b - a) * Clamp01(t);

        public static double Lerp(double a, double b, float t) => a + (b - a) * Clamp01(t);

        public static double Lerp(double a, double b, double t) => a + (b - a) * Clamp01(t);

        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            t = Clamp01(t);
            float x = a.x + (b.x - a.x) * t;
            float y = a.y + (b.y - a.y) * t;
            return new Vector2(x, y);
        }

        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
            t = Clamp01(t);
            float x = a.x + (b.x - a.x) * t;
            float y = a.y + (b.y - a.y) * t;
            float z = a.z + (b.z - a.z) * t;
            return new Vector3(x, y, z);
        }

        public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
        {
            t = Clamp01(t);
            float x = a.x + (b.x - a.x) * t;
            float y = a.y + (b.y - a.y) * t;
            float z = a.z + (b.z - a.z) * t;
            float w = a.w + (b.w - a.w) * t;
            return new Vector4(x, y, z, w);
        }

        #endregion

        #region LerpUnclamped

        public static float LerpUnclamped(float a, float b, float t) => a + (b - a) * t;

        public static double LerpUnclamped(double a, double b, float t) => a + (b - a) * t;

        public static double LerpUnclamped(double a, double b, double t) => a + (b - a) * t;

        public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t)
        {
            float x = a.x + (b.x - a.x) * t;
            float y = a.y + (b.y - a.y) * t;
            return new Vector2(x, y);
        }

        public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t)
        {
            float x = a.x + (b.x - a.x) * t;
            float y = a.y + (b.y - a.y) * t;
            float z = a.z + (b.z - a.z) * t;
            return new Vector3(x, y, z);
        }

        public static Vector4 LerpUnclamped(Vector4 a, Vector4 b, float t)
        {
            float x = a.x + (b.x - a.x) * t;
            float y = a.y + (b.y - a.y) * t;
            float z = a.z + (b.z - a.z) * t;
            float w = a.w + (b.w - a.w) * t;
            return new Vector4(x, y, z, w);
        }

        #endregion

        #region Abs
        public static sbyte Abs(sbyte a) => Math.Abs(a);

        public static short Abs(short a) => Math.Abs(a);

        public static int Abs(int a) => Math.Abs(a);

        public static long Abs(long a) => Math.Abs(a);

        public static float Abs(float a) => MathF.Abs(a);

        public static double Abs(double a) => Math.Abs(a);

        public static decimal Abs(decimal a) => Math.Abs(a);
        #endregion

        public static float Sqrt(float a) => MathF.Sqrt(a);

        public static double Sqrt(double a) => Math.Sqrt(a);

        public static float Pow2(float a) => a * a;

        public static double Pow2(double a) => a * a;

        /*========================================================================================*/

        public static float SqrMagnitude(float x, float y)
            => (x * x) + (y * y);

        public static float SqrMagnitude(Vector2 vector)
            => (vector.x * vector.x) + (vector.y * vector.y);

        public static int SqrMagnitude(int x, int y) => (x * x) + (y * y);

        public static int SqrMagnitude(Vector2Int vector)
            => (vector.x * vector.x) + (vector.y * vector.y);

        public static float SqrMagnitude(float x, float y, float z) => (x * x) + (y * y) + (z * z);

        public static float SqrMagnitude(Vector3 vector)
            => (vector.x * vector.x) + (vector.y * vector.y) + (vector.z * vector.z);

        public static int SqrMagnitude(int x, int y, int z)
            => (x * x) + (y * y) + (z * z);

        public static int SqrMagnitude(Vector3Int vector)
            => (vector.x * vector.x) + (vector.y * vector.y) + (vector.z * vector.z);


        public static float Magnitude(Vector2 vector)
            => Sqrt((vector.x * vector.x) + (vector.y * vector.y));

        public static float Magnitude(float x, float y) => Sqrt((x * x) + (y * y));

        public static float Magnitude(Vector2Int vector)
            => Sqrt((vector.x * vector.x) + (vector.y * vector.y));

        public static float Magnitude(int x, int y) => Sqrt((x * x) + (y * y));

        public static float Magnitude(Vector3 vector)
            => Sqrt((vector.x * vector.x) + (vector.y * vector.y) + (vector.z * vector.z));

        public static float Magnitude(float x, float y, float z)
            => Sqrt((x * x) + (y * y) + (z * z));

        public static float Magnitude(int x, int y, int z) => Sqrt((x * x) + (y * y) + (z * z));

        public static float Magnitude(Vector3Int vector)
            => Sqrt((vector.x * vector.x) + (vector.y * vector.y) + (vector.z * vector.z));

        public static Vector3 Normalize(float x, float y, float z)
        {
            float sqrMagnitude = (x * x) + (y * y) + (z * z);
            if (sqrMagnitude < 1E-10f)
            {
                return Vector3.zero;
            }
            float magnitude = Sqrt(sqrMagnitude);
            float invLength = 1.0f / magnitude;
            return new Vector3()
            {
                x = x * invLength,
                y = y * invLength,
                z = z * invLength
            };
        }

        /*========================================================================================*/

        /// <summary>
        /// Округляет значение double до ближайшего кратного указанному шагу.
        /// </summary>
        /// <param name="value">Исходное значение для округления.</param>
        /// <param name="step">Шаг округления (должен быть больше 0).</param>
        /// <returns>Значение, округленное до ближайшего целого числа шагов.</returns>
        public static double RoundWithStep(double value, double step)
            => Math.Round(value / step) * step;

        /// <summary>
        /// Округляет значение float до ближайшего кратного указанному шагу.
        /// </summary>
        /// <param name="value">Исходное значение для округления.</param>
        /// <param name="step">Шаг округления (должен быть больше 0).</param>
        /// <returns>Значение, округленное до ближайшего целого числа шагов.</returns>
        public static float RoundWithStep(float value, float step)
            => Mathf.Round(value / step) * step;

        /// <summary>
        /// Нормализует угол в градусах в диапазон [-180, 180] с полной поддержкой любых входных значений.
        /// Гарантирует корректную обработку углов за пределами [-360, 360].
        /// </summary>
        /// <param name="angle">Произвольный угол в градусах (может быть больше 360 или меньше -360)</param>
        /// <returns>Эквивалентный угол в диапазоне [-180, 180]</returns>
        public static float WrapAngle180(float angle)
        {
            angle %= 360.0f;
            if (angle > 180.0f)
            {
                return -360.0f + angle;
            }
            else if (angle < -180.0f)
            {
                return 360.0f + angle;
            }
            return angle;
        }

        /// <summary>
        /// Быстрая нормализация угла в диапазон [-180, 180] для значений, уже находящихся в [-360, 360].
        /// Не выполняет предварительное приведение через modulo, поэтому требует соблюдения входных условий.
        /// </summary>
        /// <param name="angle">Угол в градусах, гарантированно находящийся в диапазоне [-360, 360]</param>
        /// <returns>Эквивалентный угол в диапазоне [-180, 180]</returns>
        /// <remarks>
        /// ВНИМАНИЕ: Для углов за пределами [-360, 360] возвращает некорректный результат.
        /// Используйте только когда уверены во входном диапазоне.
        /// </remarks>
        public static float WrapAngle180Fast(float angle)
        {
            if (angle > 180.0f)
            {
                return -360.0f + angle;
            }
            else if (angle < -180.0f)
            {
                return 360.0f + angle;
            }
            return angle;
        }


        /// <summary>
        /// Реализует пружинную физику для плавного движения значения к цели; в качестве промежутка времени используется <c>Time.deltaTime</c>.
        /// </summary>
        /// <param name="current">Текущее значение.</param>
        /// <param name="target">Целевое значение.</param>
        /// <param name="velocity">Ссылка на переменную скорости (модифицируется в процессе).</param>
        /// <param name="damping">Коэффициент демпфирования: чем больше значение, тем быстрее затухают колебания. Рекомендуемый диапазон - [5-40].</param>
        /// <param name="stiffness">Жёсткость пружины: чем больше значение, тем быстрее движение пружины. Рекомендуемый диапазон - [10-500].</param>
        /// <returns>Новое значение после применения пружинной физики.</returns>
        public static float Spring(
            float current,
            float target,
            ref float velocity,
            float damping,
            float stiffness)
            => Spring(current, target, ref velocity, damping, stiffness, Time.deltaTime);

        /// <summary>
        /// Реализует пружинную физику для плавного движения значения к цели.
        /// </summary>
        /// <param name="current">Текущее значение.</param>
        /// <param name="target">Целевое значение.</param>
        /// <param name="velocity">Ссылка на переменную скорости (модифицируется в процессе).</param>
        /// <param name="damping">Коэффициент демпфирования: чем больше значение, тем быстрее затухают колебания. Рекомендуемый диапазон - [5-40].</param>
        /// <param name="stiffness">Жёсткость пружины: чем больше значение, тем быстрее движение пружины. Рекомендуемый диапазон - [10-500].</param>
        /// <param name="deltaTime">Временной шаг.</param>
        /// <returns>Новое значение после применения пружинной физики.</returns>
        public static float Spring(
            float current,
            float target,
            ref float velocity,
            float damping,
            float stiffness,
            float deltaTime)
        {
            float delta = current - target;
            velocity += ((-stiffness * delta) - (damping * velocity)) * deltaTime;
            return current + (velocity * deltaTime);
        }

        public static float FastSin(float x)
        {
            // Приводим x к диапазону 0..PI
            x = Mathf.Repeat(x, Mathf.PI);
            return (4f * x * (Mathf.PI - x)) / (Mathf.PI * Mathf.PI - x * (Mathf.PI - x));
        }

        public static float HarmonicDamp(
          float current,
          ref float velocity,
          float target,
          float frequency,
          float damping,
          float deltaTime)
        {
            float delta = current - target;
            velocity += (-damping * velocity) - (frequency * delta);
            return current + (velocity * deltaTime);
        }
    }
}
