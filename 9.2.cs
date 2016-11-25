using System;
using System.Linq;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-5, 25);
                Console.Write($"{i}) {arr[i]}");
            }

            Console.WriteLine($"\nИндекс наибольшего: {Array.IndexOf(arr, arr.Min())} \nИндекс наименьшего: {Array.IndexOf(arr, arr.Max())}");

            Console.Read();

        }
    }
}
