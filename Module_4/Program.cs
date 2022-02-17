using System;

namespace Module_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }};

            //Первый
            //Console.Write("Количество строк: ");
            //Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

            //Console.Write("Количество колонок: ");
            //Console.WriteLine(array.GetUpperBound(1) + 1 + " ");

            //Второй
            //for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            //{
            //    for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
            //    Console.Write(array[k, i] + " ");

            //    Console.WriteLine();
            //}

            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //  sum += arr[i];
            //}

            //Console.WriteLine(sum);

            //Console.ReadKey();

            //Третий
            //int[][] array = new int[3][];

            //array[0] = new int[2] { 1, 2 };
            //array[1] = new int[3] { 1, 2, 3 };
            //array[2] = new int[5] { 1, 2, 3, 4, 5 };

            //foreach (var num in array)
            //{
            //    foreach (var item in num)
            //    {
            //        Console.Write(item + " ");
            //    }
            //}

            //Четвертый
            //int[] array_2 = { -1, -2, 4, 8, -5 };

            //int sum = 0;

            //for (int i = 0; i < array_2.Length; i++)
            //{
            //    if (array_2[i] > 0)
            //        sum += array_2[i];
            //}

            //Console.WriteLine(sum);

            //Пятый
            //int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            //int temp = 0;

            //for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
            //        if (arr[i, j] > 0)
            //            temp += arr[i, j];
            //}

            //Console.WriteLine(temp);

            //Шестой
            //int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            //int temp;

            //for (int i = 0; i <= arr.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= arr.GetUpperBound(1); j++)
            //        for (int k = j+1; k <= arr.GetUpperBound(1); k++)
            //            if (arr[i,j] > arr [i, k])
            //            {
            //                temp = arr[i, k];
            //                arr[i,k] = arr[i, j];
            //                arr[i,j] = temp;
            //            }
            //}

            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}

            //Повтор
            //int[,] array = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

            //Console.Write("Количество строк: ");
            //Console.WriteLine(array.GetUpperBound(0) + 1);

            //Console.Write("Количество колонок: ");
            //Console.WriteLine(array.GetUpperBound(1) + 1);

            //for (int j = 0; j < array.GetUpperBound(0) + 1; j++)
            //{
            //    for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
            //        Console.Write(array[j, k] + " ");

            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
            //{
            //    for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
            //        Console.Write(array[k, j] + " ");

            //    Console.WriteLine();
            //}


            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            //int temp;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}

            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}

            //Console.WriteLine();

            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}

            //Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}