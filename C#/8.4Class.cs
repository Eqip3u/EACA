using System;

namespace AutomorphicNumber
{
    class Automorphic
    {
        public static bool isAutomorphic(int x)
        {
            int countOfDigit = (int)Math.Log10(x) + 1;

            return (x * x) % DecimalFactor(countOfDigit) == x;
        }

        public static int DecimalFactor(int n)
        {
            int temp = 1;
            for (int i = 0; i < n; i++)
                temp *= 10;
            return temp;
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            int userNumber = int.Parse(Console.ReadLine());

            if (Automorphic.isAutomorphic(userNumber))
                Console.WriteLine("Число {0} автоморфно", userNumber);
            else
                Console.WriteLine("Число {0} не автоморфно", userNumber);
        }
    }
}
