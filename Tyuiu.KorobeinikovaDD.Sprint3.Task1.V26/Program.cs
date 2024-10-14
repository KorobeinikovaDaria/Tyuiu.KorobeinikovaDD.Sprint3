// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint3.Task1.V26.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Оператор цикла while                                                  *");
Console.WriteLine("* Задание #1                                                                  *");
Console.WriteLine("* Вариант #26                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Написать программу на С#, используя цикл while, которая вычисляет сумму     *");
Console.WriteLine("* ряда по формуле                                                             *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

int value = 5;
int startValue = 1;
int stopValue = 8;

Console.WriteLine("Переменная n = " + value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("Cумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
Console.ReadKey();
