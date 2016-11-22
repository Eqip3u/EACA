using System;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            var aX = int.Parse(Console.ReadLine());
            var aY = int.Parse(Console.ReadLine());

            var flag = Math.Pow(aX, 2) + Math.Pow(aY, 2) <= 16;

            if (aX < 0 && aY > 0 && flag)
                Console.WriteLine("Точка на заштрихованной области A");

            if (aX > 0 && aY < aX - 2 && flag)
                Console.WriteLine("Точка на заштрихованной области B");

            if (aX < 0 && aY < aX - 2 && flag)
                Console.WriteLine("Точка на заштрихованной области C");

            Console.Read();
        }
    }
}
