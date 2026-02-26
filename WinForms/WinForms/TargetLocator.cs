using System;
using System.Collections.Generic;
using System.Linq;

namespace WinForms
{
    /// <summary>
    /// Статический класс для определения координат цели на основе триангуляции.
    /// </summary>
    public static class TargetLocator
    {
        /// <summary>
        /// Вычисляет модуль числа с учётом отрицательных значений.
        /// </summary>
        /// <param name="x">Исходное число</param>
        /// <param name="m">Модуль</param>
        /// <returns>Положительный остаток от деления</returns>
        private static double Mod(double x, double m)
        {
            double result = x % m;
            return result < 0 ? result + m : result;
        }

        /// <summary>
        /// Находит среднюю точку между двумя точками и расстояние между ними.
        /// </summary>
        /// <param name="point1">Первая точка [x, y]</param>
        /// <param name="point2">Вторая точка [x, y]</param>
        /// <returns>Массив: [средний X, средний Y, расстояние]</returns>
        public static double[] AveragePoints(double[] point1, double[] point2)
        {
            if (point1 == null) point1 = point2;
            if (point2 == null) point2 = point1;

            return new double[]
            {
                (point1[0] + point2[0]) / 2,
                (point1[1] + point2[1]) / 2,
                Math.Sqrt(Math.Pow(point1[0] - point2[0], 2) + Math.Pow(point1[1] - point2[1], 2))
            };
        }

        /// <summary>
        /// Находит точки пересечения двух окружностей.
        /// </summary>
        /// <param name="x1">X-координата центра первой окружности</param>
        /// <param name="y1">Y-координата центра первой окружности</param>
        /// <param name="x2">X-координата центра второй окружности</param>
        /// <param name="y2">Y-координата центра второй окружности</param>
        /// <param name="radius1">Радиус первой окружности</param>
        /// <param name="radius2">Радиус второй окружности</param>
        /// <param name="height">Высота (Z-координата точек пересечения)</param>
        /// <returns>Массив из двух точек пересечения [ [x1, y1, z], [x2, y2, z] ]</returns>
        /// <exception cref="Exception">Если окружности не пересекаются</exception>
        public static double[][] FindCircleIntersection(
            double x1, double y1, double x2, double y2,
            double radius1, double radius2, double height = 0)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            // Проверка случаев отсутствия пересечения
            if (distance > radius1 + radius2)
                throw new Exception("Окружности не пересекаются (расстояние больше суммы радиусов)");

            if (distance < Math.Abs(radius1 - radius2))
                throw new Exception("Одна окружность полностью внутри другой без пересечений");

            if (distance == 0 && radius1 == radius2)
                throw new Exception("Окружности совпадают (бесконечное число точек пересечения)");

            // Вычисление точек пересечения
            double a = (Math.Pow(radius1, 2) - Math.Pow(radius2, 2) + Math.Pow(distance, 2)) / (2 * distance);
            double h = Math.Sqrt(Math.Pow(radius1, 2) - Math.Pow(a, 2));

            double x_mid = x1 + a * dx / distance;
            double y_mid = y1 + a * dy / distance;

            // Координаты точек пересечения
            var point1 = new double[]
            {
                x_mid - h * dy / distance,
                y_mid + h * dx / distance,
                height
            };

            var point2 = new double[]
            {
                x_mid + h * dy / distance,
                y_mid - h * dx / distance,
                height
            };

            return new double[][] { point1, point2 };
        }

        /// <summary>
        /// Основной метод для вычисления координат цели.
        /// </summary>
        /// <param name="O1_X">X-координата первого наблюдателя</param>
        /// <param name="O1_Y">Y-координата первого наблюдателя</param>
        /// <param name="O2_X">X-координата второго наблюдателя</param>
        /// <param name="O2_Y">Y-координата второго наблюдателя</param>
        /// <param name="L1">Расстояние от первого наблюдателя до БПЛА</param>
        /// <param name="L2">Расстояние от второго наблюдателя до БПЛА</param>
        /// <param name="L3">Расстояние от БПЛА до цели</param>
        /// <param name="H">Высота БПЛА</param>
        /// <param name="a">Угол между направлением на цель и базовой линией (в градусах)</param>
        /// <param name="b">Угол между направлением на цель и базовой линией (в градусах)</param>
        /// <param name="aa">Угол позиционный на ОО1 (в градусах)</param>
        /// <param name="bb">Угол позиционный на ОО2 (в градусах)</param>
        /// <param name="c">Угол позиционный на Цель (в градусах)</param>
        /// <returns>
        /// Массив из двух точек:
        /// - [0] Координаты БПЛА [x, y, z]
        /// - [1] Координаты цели [x, y, 0]
        /// </returns>
        public static double[][] GetTargetCoordinates(
            double O1_X, double O1_Y, double O1_Z, double O2_X, double O2_Y, double O2_Z,
            double L1, double L2, double L3, double a, double b, double aa, double bb, double c)
        {
            double H = ((O1_Z - Math.Sin(aa * Math.PI / 180) * L1) +
                        (O2_Z - Math.Sin(bb * Math.PI / 180) * L2)) / 2;
            double l1 = L1 * Math.Cos(aa * Math.PI / 180);
            double l2 = L2 * Math.Cos(bb * Math.PI / 180);

            // Находим позицию БПЛА (пересечение двух окружностей)
            double[] BPLA = FindCircleIntersection(O1_X, O1_Y, O2_X, O2_Y, l1, l2, 0)[
                (Mod((Math.PI + Math.PI * (a - b) / 180) , (2 * Math.PI)) - Math.PI) > 0 ? 1 : 0
            ];

            // Вычисляем расстояния для триангуляции цели
            double l3 = L3 * Math.Cos(c * Math.PI / 180);
            double r1 = Math.Sqrt(l1 * l1 + l3 * l3 - 2 * l1 * l3 * Math.Cos(Math.PI * Math.Abs(a) / 180));
            double r2 = Math.Sqrt(l2 * l2 + l3 * l3 - 2 * l2 * l3 * Math.Cos(Math.PI * Math.Abs(b) / 180));

            // Находим возможные позиции цели
            var points1 = FindCircleIntersection(BPLA[0], BPLA[1], O1_X, O1_Y, l3, r1);
            var points2 = FindCircleIntersection(BPLA[0], BPLA[1], O2_X, O2_Y, l3, r2);

            // Находим все возможные комбинации средних точек
            var avgPoints = new List<double[]>
            {
                AveragePoints(points1[0], points2[0]),
                AveragePoints(points1[0], points2[1]),
                AveragePoints(points1[1], points2[0]),
                AveragePoints(points1[1], points2[1])
            };

            // Выбираем вариант с минимальным расстоянием между точками
            avgPoints.Sort((p1, p2) => p1[2].CompareTo(p2[2]));
            var bestMatch = avgPoints[0];

            return new double[][]
            {
                new double[] { BPLA[0], BPLA[1], H }, // Координаты БПЛА
                new double[] { bestMatch[0], bestMatch[1], H + L3 * Math.Sin(c * Math.PI / 180) } // Координаты цели
            };
        }

        /// <summary>
        /// Альтернативный метод вычисления координат цели (через вращение векторов).
        /// </summary>
        /// <returns>Координаты цели [x, y]</returns>
        public static double[][] GetTargetCoordinatesAlternative(
            double O1_X, double O1_Y, double O1_Z, double O2_X, double O2_Y, double O2_Z,
            double L1, double L2, double L3, double a, double b, double aa, double bb, double c)
        {
            double H = ((O1_Z - Math.Sin(aa * Math.PI / 180) * L1) +
                        (O2_Z - Math.Sin(bb * Math.PI / 180) * L2)) / 2;

            double l1 = L1 * Math.Cos(aa * Math.PI / 180);
            double l2 = L2 * Math.Cos(bb * Math.PI / 180);

            double[] BPLA = FindCircleIntersection(O1_X, O1_Y, O2_X, O2_Y, l1, l2, 0)[
                (Mod((Math.PI + Math.PI * (a - b) / 180), (2 * Math.PI)) - Math.PI) > 0 ? 1 : 0
            ];

            double l3 = L3 * Math.Cos(c * Math.PI / 180);

            // Векторное вращение для определения координат цели
            double x1 = O1_X - BPLA[0];
            double y1 = O1_Y - BPLA[1];
            double x2 = O2_X - BPLA[0];
            double y2 = O2_Y - BPLA[1];

            double rez_X1 = BPLA[0] + l3 * (x1 * Math.Cos(Math.PI * -a / 180) - y1 * Math.Sin(Math.PI * -a / 180)) / l1;
            double rez_X2 = BPLA[0] + l3 * (x2 * Math.Cos(Math.PI * -b / 180) - y2 * Math.Sin(Math.PI * -b / 180)) / l2;
            double rez_Y1 = BPLA[1] + l3 * (x1 * Math.Sin(Math.PI * -a / 180) + y1 * Math.Cos(Math.PI * -a / 180)) / l1;
            double rez_Y2 = BPLA[1] + l3 * (x2 * Math.Sin(Math.PI * -b / 180) + y2 * Math.Cos(Math.PI * -b / 180)) / l2;

            return new double[][]
            {
                new double[] { BPLA[0], BPLA[1], H }, // Координаты БПЛА
                new double[] { (rez_X1 + rez_X2) / 2, (rez_Y1 + rez_Y2) / 2, H + L3 * Math.Sin(c * Math.PI / 180) } // Координаты цели
            };
        }
    }
}