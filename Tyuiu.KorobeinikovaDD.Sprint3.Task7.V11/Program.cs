// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint3.Task7.V11.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                     *");
Console.WriteLine("* Задание #7                                                                  *");
Console.WriteLine("* Вариант #11                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции на заданном    *");
Console.WriteLine("* диапазоне -5, 5. Произвести проверку деления на ноль. Занести значения в    *");
Console.WriteLine("* массив                                                                      *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);
int len = ds.GetMassFunction(startValue, stopValue).Length;

double[] valueArray;
valueArray = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");

Console.WriteLine("+------------+------------+");
Console.WriteLine("|     X      |     f(x)   |");
Console.WriteLine("+------------+------------+");

for (int i = 0; i <= len-1; i++)
{
    Console.WriteLine("|{0,5:d}       |   {1,5:f2}    |", startValue, valueArray[i]);
    startValue++;
}

Console.WriteLine("+------------+------------+");

            
Console.ReadKey();
