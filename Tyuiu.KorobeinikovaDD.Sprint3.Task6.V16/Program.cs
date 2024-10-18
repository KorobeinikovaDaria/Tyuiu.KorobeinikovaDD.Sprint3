// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint3.Task6.V16.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Обработка целочисленной информации                                    *");
Console.WriteLine("* Задание #6                                                                  *");
Console.WriteLine("* Вариант #16                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Написать программу, которая ищет среди целых чисел, принадлежащих числовому *");
Console.WriteLine("* отрезку [5, 16] количество всех делителей                                   *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

int startValue = 5;
int stopValue = 16;

Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("Количество всех делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
Console.ReadKey();
