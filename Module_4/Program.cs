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

            int[][] array = new int[3][];

            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var num in array)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
            }

            int[] array_2 = { -1, -2, 4, 8, -5 };

            int sum = 0;

            for (int i = 0; i < array_2.Length; i++)
            {
                if (array_2[i] > 0)
                    sum += array_2[i];
            }

            Console.WriteLine(sum);
        }
    }
}
