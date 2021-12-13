using System;

namespace AreaCalc
{

    public class Area
    {
        private double pi = 3.14;

        /// <summary>
        /// Вычесление площади фигуры
        /// </summary>
        /// <param name="r"> Радиус круга </param>
        public String AreaFig(double r)
        {
            return ($"Площадь круга = { pi* Math.Pow(Math.Round(r,2), 2)}");
        }

        /// <summary>
        /// Вычесление площади фигуры
        /// </summary>
        /// <param name="a"> Сторона треугольника </param>
        /// <param name="b"> Сторона треугольника </param>
        /// <param name="c"> Сторона треугольника </param>
        public String AreaFig(double a, double b, double c)
        {
            double pp = 0;
            double s = 0;
            double gip = 0;
            double k1 = 0;
            double k2 = 0;
            String text = "";

            //ищем гипотенузу (гипотенуза максимальная из трех велечин)
            if (a > b & a > c)
            {
                gip = a;
                k1 = c;
                k2 = b;

            }
            else if (b > a & b > c)
            {
                gip = b;
                k1 = a;
                k2 = c;
            }
            else if (c > a & c > b)
            {
                gip = c;
                k1 = a;
                k2 = b;
            }

            //прямоугольный или нет
            if ((gip * gip) == (k1 * k1 + k2 * k2))
            {
                text = "Прямоугольный теругольник.";
            }
            else
            {
                text = "Треугольник не прямоугольный.";
            }

            pp = (a + b + c) / 2;

            s = Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));

            return ($"{ text}  Площадь треугольника = { Math.Round(s,2)}");
        }

    }
}
