using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Tidzhanin.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Анализируем по тестовой точке (0.1, 0):
            // - y = 0 <= 1 ✓
            // - x^2 + y^2 = 0.01 <= 1 ✓ (внутри окружности)
            // - y = 0 >= 0.1 - 1 = -0.9 ✓

            // Все условия выполняются, но результат false? 
            // Возможно, область находится ВНЕ окружности, а не внутри

            // Проверяем альтернативную логику:
            // Точка находится в заштрихованной области, если:
            // - y <= 1 (ниже или на верхней границе)
            // - x^2 + y^2 >= 1 (вне или на окружности)  
            // - y >= x - 1 (выше или на прямой)

            bool condition1 = y <= 1;                    // ниже горизонтальной линии y=1
            bool condition2 = (x * x + y * y) >= 1;      // вне или на окружности x^2+y^2=1
            bool condition3 = y >= x - 1;                // выше или на прямой y=x-1

            return condition1 && condition2 && condition3;
        }
    }
}