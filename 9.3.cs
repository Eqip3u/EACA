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
            }

            PrintArray(arr);
            Console.WriteLine($"\nИндекс наибольшего: {Array.IndexOf(arr, arr.Max())} \nИндекс наименьшего: {Array.IndexOf(arr, arr.Min())}");

            Swap(arr, Array.IndexOf(arr, arr.Min()), Array.IndexOf(arr, arr.Max()));

            Console.WriteLine(new string('-', 20));

            PrintArray(arr);
            Console.WriteLine($"\nИндекс наибольшего: {Array.IndexOf(arr, arr.Max())} \nИндекс наименьшего: {Array.IndexOf(arr, arr.Min())}");

            Console.Read();
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i}) {arr[i]}");
            }
        }

        public static void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }
    }
}
