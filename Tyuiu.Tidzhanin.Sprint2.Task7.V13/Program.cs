using Tyuiu.Tidzhanin.Sprint2.Task7.V13.Lib;

Console.Title = "Спринт #2 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Проверка попадания точки в заштрихованную область                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами *");
Console.WriteLine("* X,Y в заштрихованной области.                                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
bool result = ds.CheckDotInShadedArea(x, y);

Console.WriteLine($"Точка с координатами ({x},{y}) {(result ? "находится" : "не находится")} в заштрихованной области");

Console.ReadLine();