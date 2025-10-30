using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Tidzhanin.Sprint2.Task4.V22.Lib
{
    public class DataService : ISprint2Task4V22
    {
        public double Calculate(double x, double y)
        {
            // Используем тернарный оператор
            double z = (x - 3 > y * 2 - 21)
                ? (x * x + 12 * y - (2 / x))  // если условие истинно
                : ((x * x + Math.Pow(Math.Cos(y), 2) + 17) / (y * y - Math.Pow(Math.Sin(y), 2) + 3));  // если условие ложно

            return z;
        }
    }
}