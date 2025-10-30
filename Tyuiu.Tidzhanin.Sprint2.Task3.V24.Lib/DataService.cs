using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Tidzhanin.Sprint2.Task3.V24.Lib
{
    public class DataService : ISprint2Task3V24
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 0)
            {
                // y = x * ((10 + sin√(x+1)) / x)^x
                double numerator = 10 + Math.Sin(Math.Sqrt(x + 1));
                double fraction = numerator / x;
                y = x * Math.Pow(fraction, x);
            }
            else if (x == 0)
            {
                // y = cos(x) + (12 / x^2) - при x=0 деление на 0
                // Возвращаем максимальное значение double
                y = double.MaxValue;
            }
            else if (x > -28)
            {
                // y = (1 + 1/x^2)^x
                double inner = 1 + 1 / (x * x);
                y = Math.Pow(inner, x);
            }
            else
            {
                // y = x^2 + 10x - (1/x)
                y = (x * x) + (10 * x) - (1 / x);
            }

            return Math.Round(y, 3);
        }
    }
}