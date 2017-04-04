using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace MiwaKrugDZ1
{
    class Program
    {
        static void BubbleSort(int[] arr)
        {
            int c = 0;
            while (c < arr.Length - 1)
            {
                if (arr[c + 1] < arr[c])
                {
                    int temp = arr[c];
                    arr[c] = arr[c + 1];
                    arr[c + 1] = temp;
                    c = 0;
                }
                else
                    c++;
            }
            
        }
        static void SortInsertion(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                int currentElement = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > currentElement)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = currentElement;
            }
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("asd.txt");

            string[] arrayMiwiKruga = sr.ReadLine().Split('_');
            
            sr.Close();

            int[] arrayMiwiKrugaSortInsertion = new int[arrayMiwiKruga.Length];
            int[] arrayMiwiKrugaBubbleSort = new int[arrayMiwiKruga.Length];

            for (int i = 0; i < arrayMiwiKruga.Length - 1; i++)
            {
                arrayMiwiKrugaSortInsertion[i] = int.Parse(arrayMiwiKruga[i]);
                arrayMiwiKrugaBubbleSort[i] = int.Parse(arrayMiwiKruga[i]);
            }

            Stopwatch watch = new Stopwatch();

            // Сортировка вставками
            watch.Start();

            SortInsertion(arrayMiwiKrugaSortInsertion);

            watch.Stop();
            Console.WriteLine($"Сортировка вставками завершила работу за: {watch.ElapsedMilliseconds} ");

            watch.Reset();
            //Закончена работа



            //Сортировка пузырьком(Глупая сортировка)
            watch.Start();

            BubbleSort(arrayMiwiKrugaBubbleSort);

            watch.Stop();
            Console.WriteLine($"Сортировка пузырьком завершила работу за: {watch.ElapsedMilliseconds}  ");
            // Закончена работа

            Console.ReadKey();
        }
        
    }
}
