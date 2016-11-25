using System;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var count = 0;
            var flagToWin = rnd.Next(0, 10);

            Console.WriteLine("Кампуктер загадал число от 0 до 9");

            while (true)
            {
                Console.WriteLine("Введите своё число");

                int numberForPlayer = int.Parse(Console.ReadLine());
                count++;

                if (numberForPlayer == flagToWin)
                    break;

                Console.WriteLine("Вы не угадали, попробуйте ещё раз");
            }

            Console.WriteLine($"Поздравляем! Вы угадали число с {count} попытки");

            Console.Read();

        }
    }
}
