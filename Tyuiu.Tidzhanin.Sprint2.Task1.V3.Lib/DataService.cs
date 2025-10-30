using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Tidzhanin.Sprint2.Task1.V3.Lib
{
    public class DataService : ISprint2Task1V3
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            // Первый элемент должен быть True, остальные False
            res[0] = (c == d) & (a < b);                    // True & True = True
            res[1] = (a > b) | (c != d);                    // False | False = False
            res[2] = (c <= d) && (a >= b);                  // True && False = False
            res[3] = (a != b) ^ (c == d);                   // True ^ True = False
            res[4] = !(a < b) || (c > d);                   // !True || False = False
            res[5] = (b > a) & !(c == d);                   // True & !True = True & False = False

            return res;
        }
    }
}