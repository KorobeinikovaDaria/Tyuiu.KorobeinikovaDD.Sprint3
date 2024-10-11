// See https://aka.ms/new-console-template for more information

using Tyuiu.KorobeinikovaDD.Sprint3.Task0.V20.Lib;
DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int value = 1;
int startValue = 1;
int stopValue = 14;

Console.WriteLine("Переменная Х = " + value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Cумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
Console.ReadKey();