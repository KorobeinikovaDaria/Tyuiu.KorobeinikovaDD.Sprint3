// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint3.Task2.V8.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Оператор цикла do-while                                               *");
Console.WriteLine("* Задание #2                                                                  *");
Console.WriteLine("* Вариант #8                                                                  *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Написать программу на С#, используя цикл do-while, которая вычисляет        *");
Console.WriteLine("* произведение ряда по формуле                                                *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

int startValue = 1;
int stopValue = 15;

Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("Cумма ряда = " + ds.GetMultiplySeries(startValue, stopValue));
Console.ReadKey();

