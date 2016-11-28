using System;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            var sumNegativeNumber = 0;
            var maxNumber = int.MinValue; // мы типо говорим что захавай самое минимальное значение int'а (maxNumber = -2147483648 )

            while (true)
            {
                var temp = int.Parse(Console.ReadLine());

                if (temp == 0)
                    break;

                if (temp < 0)
                    sumNegativeNumber += temp;

                if (maxNumber < temp)
                    maxNumber = temp;
            }

            Console.WriteLine($"\nСумма отрицательных чисел последовательности: {sumNegativeNumber} \nНаибольшее среди введённых чисел: {maxNumber}");

            Console.Read();

        }
    }
}
