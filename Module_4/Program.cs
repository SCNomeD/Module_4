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

            //Кортежи
            //(string Name, string Type, double Age, int NameCount) Pet;

            //Console.Write("Введите имя питомца: ");
            //Pet.Item1 = Console.ReadLine();

            //Console.Write("Введите тип питомца (собака, кошка и т.д.): ");
            //Pet.Item2 = Console.ReadLine();

            //Console.Write("Введите возраст питомца: ");
            //Pet.Item3 = double.Parse(Console.ReadLine());

            //Pet.Item4 = Pet.Item1.Length;

            //Console.WriteLine("Вашего питомца зовут: {0}", Pet.Item1);
            //Console.WriteLine("Тип Вашего питомца: {0}", Pet.Item2);
            //Console.WriteLine("Возраст Вашего питомца: {0}", Pet.Item3);
            //Console.WriteLine("Длина имени Вашего питомца: {0}", Pet.Item4);

            //Практикум

            (string Name, string SName, string Login, int LoginLength, bool Pet, double Age, string[] FavColors) User;

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                User.SName = Console.ReadLine();

                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                var ans = Console.ReadLine();
                if (ans == "Да")
                {
                    User.Pet = true;
                }
                else
                {
                    User.Pet = false;
                }

                Console.WriteLine("Введите возраст пользователя");
                User.Age = double.Parse(Console.ReadLine());

                User.FavColors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < User.FavColors.Length; i++)
                {
                    User.FavColors[i] = Console.ReadLine();
                }
            }

            Console.ReadKey();
        }
    }
}