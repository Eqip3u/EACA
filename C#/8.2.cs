using System;

namespace HexagonArea
{
	class Hexagon
	{
		private static int[,] QueryPoint()
		{
			var coordinates = new int[2, 6];
			Console.WriteLine("Ввод через пробел");

			for (int i = 0; i < 6; i++)
			{
				Console.Write("(x;y) {0}: ", i + 1);
				var point = Console.ReadLine().Split(' ');
				coordinates[0, i] = int.Parse(point[0]);
				coordinates[1, i] = int.Parse(point[1]);
			}

			return coordinates;
		}

		public double Area() 
		{
			int[,] coordinates = QueryPoint();

			int sum1 = 0;
			int sum2 = 0;

			for (int i = 0; i < coordinates.GetLength(1) - 1; i++)
			{
				sum1 += coordinates[0, i] * coordinates[1, i + 1];
				sum2 += coordinates[1, i] * coordinates[0, i + 1];
			}

			return Math.Abs((sum1 - sum2) / 2);
		}

	}
	class MainClass
	{
		static void Main(string[] args)
		{
			Hexagon hexagon1 = new Hexagon();

			var areaHexagon1 = hexagon1.Area();

			Console.WriteLine("Пложадь многоугольника равна {0}", areaHexagon1);

			Console.Read();
		}
	}
}