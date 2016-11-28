using System;


namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            var aX = double.Parse(Console.ReadLine());
            var aY = double.Parse(Console.ReadLine());


            if (Math.Pow(aX, 2) <= aY && aY < 2 - aX)
                Console.WriteLine("Точка на заштрихованной области C");

            if (Math.Pow(aX, 2) >= aY &&  aY < 2 - aX && aX >= 0)
                Console.WriteLine("Точка на заштрихованной области D");

            Console.Read();
        }
    }
}
