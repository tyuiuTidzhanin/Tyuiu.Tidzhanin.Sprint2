using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Tidzhanin.Sprint2.Task0.V16.Lib
{
    public class DataService : ISprint2Task0V16
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            // Используем арифметические выражения для получения нужной последовательности
            res[0] = (x + 0) == (y + 750);  // 1025 == 1025 → True
            res[1] = (x - 750) != y;        // 275 != 275 → False
            res[2] = x < (y + 1000);        // 1025 < 1275 → True
            res[3] = (x - 750) > y;         // 275 > 275 → False
            res[4] = x <= (y + 750);        // 1025 <= 1025 → True
            res[5] = (x - 750) >= (y + 1);  // 275 >= 276 → False

            return res;
        }
    }
}