using Tyuiu.Tidzhanin.Sprint2.Task4.V22.Lib;

Console.Title = "Спринт #2 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Тернарный оператор                                                *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #22                                                             *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение  *");
Console.WriteLine("* переменных x,y с клавиатуры.                                            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите значение X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение Y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.Calculate(x, y);

Console.WriteLine($"Значение Z = {result:F3}");

Console.ReadLine();