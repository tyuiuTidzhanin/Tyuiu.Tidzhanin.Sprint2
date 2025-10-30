using Tyuiu.Tidzhanin.Sprint2.Task1.V3.Lib;

Console.Title = "Спринт #2 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Логические операции                                               *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений и логических операций,         *");
Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
Console.WriteLine("* (True, False, False, False, False, False), при a = 185, b = 316,        *");
Console.WriteLine("* c = 134, d = 134                                                        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int a = 185;
int b = 316;
int c = 134;
int d = 134;

Console.WriteLine($"A = {a}");
Console.WriteLine($"B = {b}");
Console.WriteLine($"C = {c}");
Console.WriteLine($"D = {d}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
bool[] result = ds.GetLogicOperations(a, b, c, d);

Console.WriteLine("Результат:");
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}

Console.ReadLine();