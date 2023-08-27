using System;

namespace Task_4_3_17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = { { -5, 6, 9, 1, 2, -3, 22, 1000, -234, 12, 23423, 99 }, { -8, 8, 1, 1, 2, -3, 232, 222, 3456, 12, 456, 6 } };

            //int[,] arr = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } };

            // вывод массива в консоль до сортировки
            Console.WriteLine("Массив до сортировки:");

            // использовал метод .GetLength
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            //сортировка
            bool isSorted = false;
            int sortingSteps = 0;

            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 1; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] < arr[i, j - 1])
                        {
                            int temp;
                            temp = arr[i, j];
                            arr[i, j] = arr[i, j - 1];
                            arr[i, j - 1] = temp;
                            isSorted = false;
                            sortingSteps++;
                        }
                    }

                }
            }

            // вывод массива в консоль после сортировки
            if (sortingSteps == 0)
            {
                Console.WriteLine("\nМассив не требует сортировки");
            }
            else
            {
                Console.WriteLine("\nКоличество итераций сортировки: " + sortingSteps);
                Console.WriteLine("\nМассив после сортировки:");

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}