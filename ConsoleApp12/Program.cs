using System;

namespace HelloApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//L2_IF();
			L2_while();
		}

		public static void L1() 
		{
			string name = "Tom";
			int age = 34;
			double height = 1.7;
			Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");
			Console.WriteLine($"Имя: {name + age}  Возраст: {age}  Рост: {height}м");

			Console.Write("Введите свое имя:");
			string Name = Console.ReadLine();
			Console.WriteLine($"Привет {Name}");

			int x = 10;
			int z = x - 6;
			Console.WriteLine(z);
		}

		public static void L2_if() 
		{
			//if (условие) действие если условие возвращает true
			//else - выполняется когда условие отдаёт false
			
			Console.WriteLine("Enter please a number");
			int number = int.Parse(Console.ReadLine());

			if (number > 0)
			{
				Console.WriteLine($"number is upper 0");
			}
			else if (number == 0)
			{
				Console.WriteLine($"number is 0");
			}
			else
			{
				Console.WriteLine($"number is lower 0");
			}
		}

		public static void L2_for() 
		{
			//for( начальные_состояние; условия_выполнения_цикла; действие_после_итерации  )
			for (int i = 0; i < 10; i++)
			{
				Console.Write($"{i} ");
			}
		}

		public static void L2_while() 
		{
			//while (условие_выполнение) 
			int i = 0;

			while (i < 100) 
			{
				Console.WriteLine(i);
				Console.WriteLine("Enter please I");
				i = int.Parse(Console.ReadLine());
			}
		}				
	}
}