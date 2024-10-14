// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint3.Task3.V20.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Оператор цикла foreach                                                *");
Console.WriteLine("* Задание #3                                                                  *");
Console.WriteLine("* Вариант #20                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Используя цикл foreach, подсчитать колличество букв 'f' в строке:           *");
Console.WriteLine("* gfft htf f opf                                                              *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

string str = "gfft htf f opf";
char c = 'f';
double res = ds.GetCharCount(str, c);

Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("Колличество букв 'f' = " + res);
Console.ReadKey();
