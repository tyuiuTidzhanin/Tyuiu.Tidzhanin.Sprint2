using Tyuiu.Tidzhanin.Sprint2.Task2.V29.Lib;

Console.Title = "Спринт #2 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Проверка попадания точки в заштрихованную область                 *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #29                                                             *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
Console.WriteLine("* области.                                                                *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
bool result = ds.CheckDotInShadedArea(x, y);

Console.WriteLine($"Точка с координатами ({x},{y}) {(result ? "находится" : "не находится")} в заштрихованной области");

Console.ReadLine();