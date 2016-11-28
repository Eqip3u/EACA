using System;

namespace AutomorphicNumber
{
	class MainClass
	{
		static bool isAutomorphic(int x) // https://written.ru/articles/science/automorph формула 1а
		{
			int countOfDigit = (int)Math.Log10(x) + 1; 

			return (x * x) % DecimalFactor(countOfDigit) == x;
		}

		static int DecimalFactor(int n) 
		{
			int temp = 1;
			for (int i = 0; i < n; i++)
				temp *= 10;
			return temp;
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Интервал от 1 до 100");

			while (true)
			{
				Console.WriteLine("Введите число:");
				var userNumber = int.Parse(Console.ReadLine());

				if (userNumber == 1)
				{
					Console.WriteLine("Число '1' не является автоморфным");
					continue;
				}

				if (isAutomorphic(userNumber))
					Console.WriteLine($"Число {userNumber} автоморфно");

				if (!isAutomorphic(userNumber))
					Console.WriteLine($"Число {userNumber} не автоморфно");
			}

		}
	}
}
