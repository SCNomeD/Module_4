﻿using System;

namespace Module_4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите своё имя");

			var name = Console.ReadLine();

			for (int i = name.Length - 1; i >=0; i--)
            {
                Console.WriteLine(name[i]);
            }

			Console.ReadKey();
		}
    }
}
