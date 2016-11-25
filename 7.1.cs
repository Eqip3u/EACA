using System;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            double z = double.Parse(Console.ReadLine());
            double ST = double.Parse(Console.ReadLine());

            double d = 1;
            double zt = z;
            double p = 0;

            do
            {
                p = zt / 300.0;
                zt += p;
                d++;

            } while (zt < 2 * z);

            Console.WriteLine($"Кол-во дней: {d} \nОбщая сумма задолжности: {zt}");

            Console.Read();

        }
    }
}
