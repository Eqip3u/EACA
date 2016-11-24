using System;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int sum = 0;
            int count = 0;

            for (int i = 0; i < 15; i++)
            {
                int temp = rnd.Next(0, 25);

                if (temp % 3 == 0 && temp >= 3)
                {
                    sum = sum + temp;
                    count++;
                }

                Console.WriteLine(temp);

            }

            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Среднее арифметическое = {0}", sum / count);

            Console.Read();

        }
    }
}
