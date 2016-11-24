using System;

namespace gay
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', 20));

            while (a <= b)
            {
                if (a < -1)
                    Console.WriteLine(Math.Pow(a, 2));
                else if (-1 <= a && a <= 1)
                    Console.WriteLine(0.5);
                else if (a > 1)
                    Console.WriteLine(a * 0.5);

                a += 0.5;
            }

            Console.WriteLine(new string('-', 20));

            Console.Read();

        }
    }
}
