using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSequenceNumber
{
    class Program
    {
        static string UserSequenceNumber()
        {
            string sumString = "";
            Console.WriteLine("Введите число \t Для выхода из последовательности введите '0'");
            while (true)
            {
                string userString = Console.ReadLine();

                if (userString == "0")
                    break;

                sumString += userString;
                Console.WriteLine("Вы ввели - {0}", userString);
            }
            return sumString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма вашей последовательности = {0}", UserSequenceNumber());
            Console.Read();
        }
    }
}
