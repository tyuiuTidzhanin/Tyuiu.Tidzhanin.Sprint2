using Tyuiu.Tidzhanin.Sprint2.Task6.V10.Lib;

Console.Title = "Спринт #2 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Сокращенная форма оператора switch                                *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: g (год),*");
Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным g, n и m определить*");
Console.WriteLine("* дату предыдущего дня. Заданный год не является високосным.              *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите год (g): ");
int g = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите месяц (m): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число (n): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
string result = ds.FindDateOfPreviousDay(g, m, n);

Console.WriteLine($"Дата предыдущего дня: {result}");

Console.ReadLine();