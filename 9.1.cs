using System;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[10];
            int sumPositiveNumber = 0;
            int sumNegativeNumber = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 10);
                Console.Write($"{arr[i]}; ");

                if (arr[i] >= 0)
                    sumPositiveNumber += arr[i];

                if (arr[i] < 0)
                    sumNegativeNumber += arr[i];
            }

            Console.WriteLine($"\nСумма положительный чисел: {sumPositiveNumber} \nСумма отрицательных чисел: {sumNegativeNumber}");

            Console.Read();

        }
    }
}
