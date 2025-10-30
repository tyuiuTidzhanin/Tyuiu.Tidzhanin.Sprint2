using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Tidzhanin.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int prevDay = n - 1;
            int prevMonth = m;
            int prevYear = g;

            // Если день первый в месяце
            if (prevDay == 0)
            {
                prevMonth--;

                // Если месяц первый в году
                if (prevMonth == 0)
                {
                    prevMonth = 12;
                    prevYear--;
                }

                // Определяем количество дней в предыдущем месяце
                prevDay = prevMonth switch
                {
                    1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                    4 or 6 or 9 or 11 => 30,
                    2 => 28, // год не високосный
                    _ => 0
                };
            }

            // Форматируем с ведущими нулями
            string formattedDay = prevDay.ToString("D2");
            string formattedMonth = prevMonth.ToString("D2");

            return $"{formattedDay}.{formattedMonth}.{prevYear}";
        }
    }
}