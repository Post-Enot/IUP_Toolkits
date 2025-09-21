using System;
using UnityEngine;

namespace IUP.Toolkits
{
    public static class Geometry
    {
        /// <summary>
        /// Вычисляет мировые координаты 8 углов <see cref="BoxCollider"/> с учётом текущей трансформации объекта.
        /// </summary>
        /// <param name="collider">Целевой <see cref="BoxCollider"/>.</param>
        /// <param name="buffer">
        /// Буфер для записи углов размером минимум 8 элементов.<br/><br/>
        /// Порядок точек:<br/>
        /// 0 левый-верхний-задний  (-X, +Y, -Z)<br/>
        /// 1 правый-верхний-задний (+X, +Y, -Z)<br/>
        /// 2 правый-верхний-передний (+X, +Y, +Z)<br/>
        /// 3 левый-верхний-передний (-X, +Y, +Z)<br/>
        /// 4 левый-нижний-задний   (-X, -Y, -Z)<br/>
        /// 5 правый-нижний-задний  (+X, -Y, -Z)<br/>
        /// 6 правый-нижний-передний (+X, -Y, +Z)<br/>
        /// 7 левый-нижний-передний (-X, -Y, +Z)
        /// </param>
        public static void BoxColliderCorners(BoxCollider collider, Span<Vector3> buffer)
        {
            Vector3 center = collider.center;
            Vector3 halfSize = collider.size * 0.5f;
            buffer[0] = center + new Vector3(-halfSize.x, halfSize.y, -halfSize.z);
            buffer[1] = center + new Vector3(halfSize.x, halfSize.y, -halfSize.z);
            buffer[2] = center + new Vector3(halfSize.x, halfSize.y, halfSize.z);
            buffer[3] = center + new Vector3(-halfSize.x, halfSize.y, halfSize.z);
            buffer[4] = center + new Vector3(-halfSize.x, -halfSize.y, -halfSize.z);
            buffer[5] = center + new Vector3(halfSize.x, -halfSize.y, -halfSize.z);
            buffer[6] = center + new Vector3(halfSize.x, -halfSize.y, halfSize.z);
            buffer[7] = center + new Vector3(-halfSize.x, -halfSize.y, halfSize.z);
            collider.transform.TransformPoints(buffer);
        }

        /// <summary>
        /// Вычисляет приблизительные мировые координаты 8 углов сферы, аппроксимируя её кубом с
        /// заданной ориентацией осей.
        /// </summary>
        /// <param name="collider">Целевой <see cref="SphereCollider"/>.</param>
        /// <param name="buffer">
        /// Буфер для записи углов размером минимум 8 элементов.<br/><br/>
        /// Порядок точек:<br/>
        /// 0: Право-Верх-Вперёд  (+X, +Y, +Z)<br/>
        /// 1: Право-Верх-Назад   (+X, +Y, -Z)<br/>
        /// 2: Право-Низ-Вперёд   (+X, -Y, +Z)<br/>
        /// 3: Право-Низ-Назад    (+X, -Y, -Z)<br/>
        /// 4: Лево-Верх-Вперёд   (-X, +Y, +Z)<br/>
        /// 5: Лево-Верх-Назад    (-X, +Y, -Z)<br/>
        /// 6: Лево-Низ-Вперёд    (-X, -Y, +Z)<br/>
        /// 7: Лево-Низ-Назад     (-X, -Y, -Z)
        /// </param>
        /// <param name="axisUp">Мировой нормализированный вектор направления "вверх".</param>
        /// <param name="axisForward">Мировой нормализированный вектор направления "вперёд".</param>
        /// <param name="axisRight">Мировой нормализированный вектор направления "вправо".</param>
        /// <exception cref="ArgumentException">Если размер буфера меньше 8.</exception>
        public static void SphereColliderCornersApproximately(
            SphereCollider collider,
            Span<Vector3> buffer,
            Vector3 axisUp,
            Vector3 axisForward,
            Vector3 axisRight)
        {
            // Учёт масштаба и преобразование центра
            Vector3 center = collider.transform.TransformPoint(collider.center);
            float maxScale = IUP_Math.Max(collider.transform.lossyScale);
            float scaledRadius = collider.radius * maxScale;

            // Вычисление углов
            buffer[0] = center + (axisRight + axisUp + axisForward) * scaledRadius;
            buffer[1] = center + (axisRight + axisUp - axisForward) * scaledRadius;
            buffer[2] = center + (axisRight - axisUp + axisForward) * scaledRadius;
            buffer[3] = center + (axisRight - axisUp - axisForward) * scaledRadius;
            buffer[4] = center + (-axisRight + axisUp + axisForward) * scaledRadius;
            buffer[5] = center + (-axisRight + axisUp - axisForward) * scaledRadius;
            buffer[6] = center + (-axisRight - axisUp + axisForward) * scaledRadius;
            buffer[7] = center + (-axisRight - axisUp - axisForward) * scaledRadius;
        }

        /// <summary>
        /// Проверяет, находится ли точка внутри сферы, используя сравнение квадратов расстояний.
        /// </summary>
        /// <param name="point">Проверяемая точка в мировых координатах.</param>
        /// <param name="center">Центр сферы в мировых координатах.</param>
        /// <param name="radius">Радиус сферы (должен быть положительным).</param>
        /// <returns>
        /// true, если точка находится внутри сферы или на её поверхности;<br/>
        /// false, если точка снаружи или радиус отрицательный.
        /// </returns>
        public static bool IsPointInSphere(Vector3 point, Vector3 center, float radius)
        {
            if (radius <= 0.0f)
            {
                return false;
            }
            Vector3 localPoint = point - center;
            float distanceSqr = IUP_Math.SqrMagnitude(localPoint);
            float radiusSqr = IUP_Math.Pow2(radius);
            return distanceSqr <= radiusSqr;
        }

        /// <summary>
        /// Проверяет, находится ли точка внутри цилиндра с вертикальной осью (ось Y).
        /// </summary>
        /// <param name="point">Проверяемая точка в мировых координатах.</param>
        /// <param name="cylinderCenter">Центр цилиндра в мировых координатах.</param>
        /// <param name="cylinderHeight">
        /// Высота цилиндра вдоль оси Y (должна быть положительной).
        /// </param>
        /// <param name="cylinderRadius">
        /// Радиус цилиндра в плоскости XZ (должен быть положительным).
        /// </param>
        /// <returns>
        /// true, если точка находится внутри цилиндра (включая граничные поверхности);<br/>
        /// false, если точка находится снаружи или высота или радиус цилиндра отрицательные.
        /// </returns>
        public static bool IsPointInCylinder(
            Vector3 point,
            Vector3 cylinderCenter,
            float cylinderHeight,
            float cylinderRadius)
        {
            if ((cylinderHeight <= 0.0f) || (cylinderRadius <= 0.0f))
            {
                return false;
            }
            Vector3 localPoint = point - cylinderCenter;
            float halfHeight = cylinderHeight * 0.5f;
            if (IUP_Math.Abs(localPoint.y) > halfHeight)
            {
                return false;
            }
            float horizontalDistanceSqr = IUP_Math.SqrMagnitude(localPoint.x, localPoint.z);
            float radiusSqr = IUP_Math.Pow2(cylinderRadius);
            return horizontalDistanceSqr <= radiusSqr;
        }

        /// <summary>
        /// Вычисляет 6 плоскостей усечённой пирамиды видимости камеры.<br/><br/>
        /// Порядок плоскостей:<br/>
        /// 0 левая (Left)<br/>
        /// 1 правая (Right)<br/>
        /// 2 нижняя (Down)<br/>
        /// 3 верхняя (Up)<br/>
        /// 4 ближняя (Near)<br/>
        /// 5 дальняя (Far)<br/>
        /// </summary>
        /// <param name="camera">Целевая камера для расчёта плоскостей.</param>
        /// <param name="planes">
        /// Span для записи плоскостей (должен иметь ёмкость не менее 6 элементов).<br/>
        /// Результат сохраняется в порядке: Left, Right, Down, Up, Near, Far.
        /// </param>
        public static void CalculateFrustumPlanes(Camera camera, Span<Plane> planes)
        {
            Matrix4x4 m = camera.projectionMatrix * camera.worldToCameraMatrix;
            planes[0] = CalculatePlane(m.m30 + m.m00, m.m31 + m.m01, m.m32 + m.m02, m.m33 + m.m03); // Left
            planes[1] = CalculatePlane(m.m30 - m.m00, m.m31 - m.m01, m.m32 - m.m02, m.m33 - m.m03); // Right
            planes[2] = CalculatePlane(m.m30 + m.m10, m.m31 + m.m11, m.m32 + m.m12, m.m33 + m.m13); // Down
            planes[3] = CalculatePlane(m.m30 - m.m10, m.m31 - m.m11, m.m32 - m.m12, m.m33 - m.m13); // Up
            planes[4] = CalculatePlane(m.m30 + m.m20, m.m31 + m.m21, m.m32 + m.m22, m.m33 + m.m23); // Near
            planes[5] = CalculatePlane(m.m30 - m.m20, m.m31 - m.m21, m.m32 - m.m22, m.m33 - m.m23); // Far
        }

        /// <summary>
        /// Вычисляет 5 плоскостей усечённой пирамиды видимости камеры без дальней плоскости.<br/><br/>
        /// Порядок плоскостей:<br/>
        /// 0 левая (Left)<br/>
        /// 1 правая (Right)<br/>
        /// 2 нижняя (Down)<br/>
        /// 3 верхняя (Up)<br/>
        /// 4 ближняя (Near)<br/>
        /// </summary>
        /// <param name="camera">Целевая камера для расчёта плоскостей.</param>
        /// <param name="planes">
        /// Span для записи плоскостей (должен иметь ёмкость не менее 5 элементов).<br/>
        /// Результат сохраняется в порядке: Left, Right, Down, Up, Near.
        /// </param>
        public static void CalculateFrustumPlanesWithoutFar(Camera camera, Span<Plane> planes)
        {
            Matrix4x4 m = camera.projectionMatrix * camera.worldToCameraMatrix;
            planes[0] = CalculatePlane(m.m30 + m.m00, m.m31 + m.m01, m.m32 + m.m02, m.m33 + m.m03); // Left
            planes[1] = CalculatePlane(m.m30 - m.m00, m.m31 - m.m01, m.m32 - m.m02, m.m33 - m.m03); // Right
            planes[2] = CalculatePlane(m.m30 + m.m10, m.m31 + m.m11, m.m32 + m.m12, m.m33 + m.m13); // Down
            planes[3] = CalculatePlane(m.m30 - m.m10, m.m31 - m.m11, m.m32 - m.m12, m.m33 - m.m13); // Up
            planes[4] = CalculatePlane(m.m30 + m.m20, m.m31 + m.m21, m.m32 + m.m22, m.m33 + m.m23); // Near
        }

        /// <summary>
        /// Проверяет, находится ли точка в усечённом конусе камеры в порядке: ближняя (Near),
        /// боковые (Left, Right), вертикальные (Up, Down), дальняя (Far).
        /// </summary>
        /// <param name="frustumPlanes">Набор плоскостей фрустума (минимум 5 элементов).<br/><br/>
        /// Порядок плоскостей:<br/>
        /// 0 левая (Left)<br/>
        /// 1 правая (Right)<br/>
        /// 2 нижняя (Down)<br/>
        /// 3 верхняя (Up)<br/>
        /// 4 ближняя (Near)<br/>
        /// 5 дальняя (Far)<br/>
        /// </param>
        /// <param name="point">Позиция точки в мировых координатах.</param>
        /// <returns>
        /// True, если точка находится в усечённом конусе камеры без учёта дальней плоскости;
        /// иначе false.
        /// </returns>
        public static bool IsPointInFrustum(ReadOnlySpan<Plane> frustumPlanes, Vector3 point) =>
                (frustumPlanes[4].GetDistanceToPoint(point) >= 0.0f) && // Near.
                (frustumPlanes[0].GetDistanceToPoint(point) >= 0.0f) && // Left.
                (frustumPlanes[1].GetDistanceToPoint(point) >= 0.0f) && // Right.
                (frustumPlanes[3].GetDistanceToPoint(point) >= 0.0f) && // Up.
                (frustumPlanes[2].GetDistanceToPoint(point) >= 0.0f) && // Down.
                (frustumPlanes[5].GetDistanceToPoint(point) >= 0.0f); // Far.

        /// <summary>
        /// Проверяет, находится ли точка в усечённом конусе камеры без учёта дальней плоскости в
        /// порядке: ближняя (Near), боковые (Left, Right), вертикальные (Up, Down).
        /// </summary>
        /// <param name="frustumPlanes">Набор плоскостей фрустума (минимум 5 элементов).<br/><br/>
        /// Порядок плоскостей:<br/>
        /// 0 левая (Left)<br/>
        /// 1 правая (Right)<br/>
        /// 2 нижняя (Down)<br/>
        /// 3 верхняя (Up)<br/>
        /// 4 ближняя (Near)<br/>
        /// 5 дальняя (Far) - не используется<br/>
        /// </param>
        /// <param name="point">Позиция точки в мировых координатах.</param>
        /// <returns>
        /// True, если точка находится в усечённом конусе камеры без учёта дальней плоскости;
        /// иначе false.
        /// </returns>
        public static bool IsPointInFrustumWithoutFar(
            ReadOnlySpan<Plane> frustumPlanes,
            Vector3 point) =>
                (frustumPlanes[4].GetDistanceToPoint(point) >= 0.0f) && // Near.
                (frustumPlanes[0].GetDistanceToPoint(point) >= 0.0f) && // Left.
                (frustumPlanes[1].GetDistanceToPoint(point) >= 0.0f) && // Right.
                (frustumPlanes[3].GetDistanceToPoint(point) >= 0.0f) && // Up.
                (frustumPlanes[2].GetDistanceToPoint(point) >= 0.0f); // Down.

        /// <summary>
        /// Вычисляет радиус ограничивающей сферы для цилиндра с вертикальной осью (ось Y)
        /// </summary>
        /// <param name="cylinderHeight">
        /// Высота цилиндра вдоль оси Y (должна быть положительной)
        /// </param>
        /// <param name="cylinderRadius">
        /// Радиус цилиндра в плоскости XZ (должен быть положительным)
        /// </param>
        /// <returns>
        /// Радиус сферы, полностью содержащей цилиндр с заданными параметрами
        /// </returns>
        /// <exception cref="ArgumentException"></exception>
        public static float CalculateBoundingSphereRadius(
            float cylinderHeight,
            float cylinderRadius)
        {
            if ((cylinderHeight <= 0.0f) || (cylinderRadius <= 0.0f))
            {
                throw new ArgumentException(
                    "Height and radius must be positive values",
                    nameof(cylinderHeight));
            }
            float halfHeight = cylinderHeight * 0.5f;
            return IUP_Math.Magnitude(halfHeight, cylinderRadius);
        }

        private static Plane CalculatePlane(float a, float b, float c, float d)
        {
            float magnitude = IUP_Math.Magnitude(a, b, c);
            float invLength = 1.0f / magnitude;
            Plane plane = new()
            {
                distance = d * invLength,
                normal = new Vector3()
                {
                    x = a * invLength,
                    y = b * invLength,
                    z = c * invLength
                }
            };
            return plane;
        }
    }
}
