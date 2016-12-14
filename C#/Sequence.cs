using System;

namespace Sequence
{
    class MainClass
    {
        static int UserSequenceNumber()
        {
            int sum = 0;
            Console.WriteLine("Введите число \t Для выхода из последовательности введите '0'");
            while (true)
            {
                int userNumber = int.Parse(Console.ReadLine());

                if (userNumber == 0)
                    break;

                sum += userNumber;
                Console.WriteLine("Вы ввели - {0}", userNumber);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма вашей последовательности = {0}",UserSequenceNumber());
            Console.Read();
        }
    }
}
