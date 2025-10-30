using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Tidzhanin.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // По тестовой точке (0.1, 0) видно, что область находится ВНУТРИ окружности
            // Но предыдущая логика не работала. Попробуем разделить на две области:

            // Область 1: внутри окружности И выше прямой y=x-1 И ниже y=1
            bool insideCircle = (x * x + y * y) <= 1;
            bool aboveLine = y >= x - 1;
            bool belowTop = y <= 1;

            // Область 2: возможно есть дополнительное условие
            // Проверим точку (0.1, 0):
            // insideCircle: 0.01 <= 1 ✓
            // aboveLine: 0 >= 0.1-1=-0.9 ✓  
            // belowTop: 0 <= 1 ✓
            // Все условия true, значит точка должна быть в области

            return insideCircle && aboveLine && belowTop;
        }
    }
}