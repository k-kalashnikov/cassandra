using System;

namespace HelloApp
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			1. Каждая задача из домашки должна быть написана в отдельном методе
			2. Имя метода должно назваться L[номер урока]_[тема]	 
			3. В методе Main вызывать только методы в которых ты работаешь
			 */

			L2_M7();
		}

		public static void L1()
		{
			string name = "Tom";
			int age = 34;
			double height = 1.7;
			Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");

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

		public static void L2_M1()
		{
			Console.WriteLine("Please enter X");
			int x = int.Parse(Console.ReadLine()); //17
			Console.WriteLine("Please enter Y");
			int y = int.Parse(Console.ReadLine()); //10

			L2_M2(x, y);

		}

		public static void L2_M2(int x, int y)
		{

			int min = -1001;
			int max = -1000;

			if (y > x)
			{
				max = y;
				min = x;
			}
			else
			{
				max = x;
				min = y;
			}

			// -1000 -999 -998 -997 ...... 997 998 999
			for (int j = -1000; j < 1000; j++)
			{
				if ((j > min) && (j < max))
				{
					Console.WriteLine($"{j}");
				}
			}
		}

		/*
		Задача:
		Создать метод который будет 
		1. принемать с себя два параметра
		2. Запускать счётчик for от минимального до максимального параметра 
		3. Выводить только чётные числа
		4. Параметры должны быть введены "с руки".

		 */
		public static void L2_M3()
		{
			Console.WriteLine("Please enter X");
			int x = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter Y");
			int y = int.Parse(Console.ReadLine());

			L2_M4(x, y);

		}

		public static void L2_M4(int x, int y)
		{
			int min = -1001;
			int max = -1000;

			if (y > x)
			{
				max = y;
				min = x;
			}
			else
			{
				max = x;
				min = y;
			}

			for (int i = min; i <= max; i++)
			{
				if ((i % 2) == 0)
				{
					Console.WriteLine(i);
				}
			}


		}
		public static void L2_M5()
		{
			Console.WriteLine("Please enter A");
			int A = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter B");
			int B = int.Parse(Console.ReadLine());

			L2_M6(A, B);
		}
		public static void L2_M6(int A, int B)
		{

			int result = 1;
			Console.WriteLine(result);

			while (1 < B)
			{
				result = result * A;
			}
		}
		public static void L2_M7()
		{
			Console.WriteLine("Please enter x");
			int x = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter y");
			int y = int.Parse(Console.ReadLine());
			L2_M8(x, y);
		}
		public static void L2_M8(int x, int y)
		{

			int min;
			int max;

			if (y > x)
			{
				max = y;
				min = x;
			}
			else
			{
				max = x;
				min = y;
			}

			for (int i = min; i <= max; i++)
            {
				if (isSimple(i)) //isSimple => true||false 
				{
					Console.WriteLine(i);
				}
            }
		}
		//выражение => что-то = что-то
		//все имена должны быть осмысленны
		public static bool isSimple(int number)
        {
			int count = 0;
            
			for (int i = 1; i <= number; i++)
            {
				if(number % i == 0)
                {
					count++;
                }
            }

			// всегда сначала возвращаешь отрицательные результаты, 
			// возврат положительного результата может быть только один
			if (count > 2) 
			{
				return false;
            }

			return true;
        }
		public static void Lesson2Input()
		{
			Console.WriteLine("Please enter number1");
			int number1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter number2");
			int number2 = int.Parse(Console.ReadLine());


		}
		public static void ShowFiboInRange(int number1, int number2)
		{

			int min;
			int max;

			if (number2 > number1)
			{
				max = number2;
				min = number1;
			}
			else
			{
				max = number1;
				min = number2;
			}

			int current = 1;
			int last = 0;

            while (true)
            {
				current = current + last;
				last = current - last;

				if ((min < current) && (max > current))
				{
					Console.WriteLine(current);
				}

				if (current > max) 
				{
					break;
				}
            }

            for (int currentFor = 1, lastFor = 0; 
				currentFor <= max; 
				currentFor = currentFor + lastFor, lastFor = currentFor - lastFor)
            {
				if ((min < currentFor) && (max > currentFor))
				{
					Console.WriteLine(currentFor);
				}
			}
		}

		/*
		 * Массивы
		 * тип массива, индекс, [длинну]
		 *  0 1 2 3 4 5 6 7  8  9 
		 * [1,5,7,3,9,4,3,9,10,18]
		 * 
		 * тип_данных[] имя_массива; 
		 * тип_данных[] имя_массива = new тип_данных[длинна]
		 * 
		 * {1,56,7,5,3,5}, {"bla", "blabla", "blablalbal"}
		 * 
		 * string == char[] - это надо помнить
		 */

	}
}