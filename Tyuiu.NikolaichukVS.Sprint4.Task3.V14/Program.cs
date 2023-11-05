using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NikolaichukVS.Sprint4.Task3.V14.Lib;

namespace Tyuiu.NikolaichukVS.Sprint4.Task3.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Николайчук В. С.| РПСБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Николайчук Валерия Сергеевна | РПСБ-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 7. Найдите максимальный     *");
            Console.WriteLine("* элемент в четвертой строке массива.                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5,5] {
                { 3, 2, 3, 3, 5 },
                { 2, 3, 3, 7, 3 },
                { 7, 5, 2, 7, 3 },
                { 4, 2, 7, 5, 2 },
                { 3, 5, 4, 2, 6 }, };

            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;
            Console.WriteLine("Массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{array[i, j]} \t");

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);
            Console.WriteLine("Наибольший элемент четвертой строки = " + res);

            Console.ReadKey();
        }
    }
}
