﻿using System;

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

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

			int sum = 0;

			for (int i = 0; i < arr.Length; i++)
			{
                sum += arr[i];
            }

            Console.WriteLine(sum);

            Console.ReadKey();
		}
    }
}
