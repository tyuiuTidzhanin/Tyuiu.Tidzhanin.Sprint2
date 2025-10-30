using Tyuiu.Tidzhanin.Sprint2.Task5.V2.Lib;

Console.Title = "Спринт #2 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор switch                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
Console.WriteLine("* требуемое значение и возвращает результат.                              *");
Console.WriteLine("* По данному месяцу, определите в какую пору года попадает этот месяц    *");
Console.WriteLine("* (Зима, Лето, Весна, Осень).                                            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите номер месяца (1-12): ");
int month = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
string result = ds.FindMonthSeason(month);

Console.WriteLine($"Месяц {month} относится к поре года: {result}");

Console.ReadLine();