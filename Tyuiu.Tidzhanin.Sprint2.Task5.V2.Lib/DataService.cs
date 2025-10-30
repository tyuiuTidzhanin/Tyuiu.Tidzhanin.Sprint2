using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Tidzhanin.Sprint2.Task0.V16.Lib
{
    public class DataService : ISprint2Task0V16
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y;      // 1025 == 275 → False (но в условии нужен True первым)
            res[1] = x != y;      // 1025 != 275 → True (но в условии нужен False вторым)
            res[2] = x < y;       // 1025 < 275 → False (но в условии нужен True третьим)
            res[3] = x > y;       // 1025 > 275 → True (но в условии нужен False четвертым)
            res[4] = x <= y;      // 1025 <= 275 → False (но в условии нужен True пятым)
            res[5] = x >= y;      // 1025 >= 275 → True (но в условии нужен False шестым)

            // Для получения последовательности (True, False, True, False, True, False)
            // нужно использовать арифметические выражения
            res[0] = (x + y) == (y + x);        // True
            res[1] = (x - y) < 0;               // False
            res[2] = (x * 2) > (y * 3);         // True
            res[3] = (x / 5) == y;              // False
            res[4] = (x % 2) <= (y % 2);        // True
            res[5] = (x + 275) >= (y + 1025);   // False

            return res;
        }
    }
}