using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Tidzhanin.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // Проверяем границы (сетка 15x15)
            if (x < 1 || x > 15 || y < 1 || y > 15)
                return false;

            // Определяем заштрихованные области по условию
            bool[,] shadedArea = new bool[16, 16]; // индексы 1-15 для удобства

            // Заполняем заштрихованные области согласно условию:
            // 3=3,4,5,9,10,11,12
            shadedArea[3, 3] = true;
            shadedArea[3, 4] = true;
            shadedArea[3, 5] = true;
            shadedArea[3, 9] = true;
            shadedArea[3, 10] = true;
            shadedArea[3, 11] = true;
            shadedArea[3, 12] = true;

            // 4=1,2,3,4,5,9,10,11,12
            shadedArea[4, 1] = true;
            shadedArea[4, 2] = true;
            shadedArea[4, 3] = true;
            shadedArea[4, 4] = true;
            shadedArea[4, 5] = true;
            shadedArea[4, 9] = true;
            shadedArea[4, 10] = true;
            shadedArea[4, 11] = true;
            shadedArea[4, 12] = true;

            // 6=3,4,5,6,7,8,9,10,11,12,13
            shadedArea[6, 3] = true;
            shadedArea[6, 4] = true;
            shadedArea[6, 5] = true;
            shadedArea[6, 6] = true;
            shadedArea[6, 7] = true;
            shadedArea[6, 8] = true;
            shadedArea[6, 9] = true;
            shadedArea[6, 10] = true;
            shadedArea[6, 11] = true;
            shadedArea[6, 12] = true;
            shadedArea[6, 13] = true;

            // 7=3,4,5,6,7,8,9,10,11,12,13
            shadedArea[7, 3] = true;
            shadedArea[7, 4] = true;
            shadedArea[7, 5] = true;
            shadedArea[7, 6] = true;
            shadedArea[7, 7] = true;
            shadedArea[7, 8] = true;
            shadedArea[7, 9] = true;
            shadedArea[7, 10] = true;
            shadedArea[7, 11] = true;
            shadedArea[7, 12] = true;
            shadedArea[7, 13] = true;

            // 8=6,10,11,12,13
            shadedArea[8, 6] = true;
            shadedArea[8, 10] = true;
            shadedArea[8, 11] = true;
            shadedArea[8, 12] = true;
            shadedArea[8, 13] = true;

            // 9=6,10,11,12
            shadedArea[9, 6] = true;
            shadedArea[9, 10] = true;
            shadedArea[9, 11] = true;
            shadedArea[9, 12] = true;

            // 10=6,10,11,12
            shadedArea[10, 6] = true;
            shadedArea[10, 10] = true;
            shadedArea[10, 11] = true;
            shadedArea[10, 12] = true;

            // 11=3,4,5,6,10,11,12
            shadedArea[11, 3] = true;
            shadedArea[11, 4] = true;
            shadedArea[11, 5] = true;
            shadedArea[11, 6] = true;
            shadedArea[11, 10] = true;
            shadedArea[11, 11] = true;
            shadedArea[11, 12] = true;

            // 12=4,5,10
            shadedArea[12, 4] = true;
            shadedArea[12, 5] = true;
            shadedArea[12, 10] = true;

            return shadedArea[x, y];
        }
    }
}