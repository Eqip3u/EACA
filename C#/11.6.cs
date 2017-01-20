using System;
using System.Collections.Generic;
using System.IO;

namespace radiotex
{
    class Program
    {
        static void Main(string[] args)
        {
            var userNumber = int.Parse(Console.ReadLine());

            StreamReader thread = File.OpenText("file.txt");

            string line;
            string[] buf;
            List<int> arrAllNumber = new List<int>();
            int countNumberInFile = 0;

            while ((line = thread.ReadLine()) != null)
            {
                buf = line.Split(',');
                countNumberInFile += buf.Length; // кол-во всех чисел в файле
            }
            thread.Close();

            thread = File.OpenText("file.txt");
            if (!(countNumberInFile < userNumber))
            {
                while ((line = thread.ReadLine()) != null)
                {

                    buf = line.Split(',');

                    for (int i = 0; i < buf.Length; i++)
                        arrAllNumber.Add(int.Parse(buf[i]));
                }

                foreach (var item in arrAllNumber)
                    Console.WriteLine(item);
                arrAllNumber.ToArray();
            }
            else
                Console.WriteLine("программа не может выполниться");

            Console.ReadKey();
        }
    }
}
