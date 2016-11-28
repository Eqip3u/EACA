using System;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                    if (day <= 19)
                        Console.WriteLine("Козерог");
                    else
                        Console.WriteLine("Водолей");
                    break;
                case 2:
                    if (day <= 18)
                        Console.WriteLine("Водолей");
                    else
                        Console.WriteLine("Рыбы");
                    break;
                case 3:
                    if (day <= 20)
                        Console.WriteLine("Рыбы");
                    else
                        Console.WriteLine("Овен");
                    break;
                case 4:
                    if (day <= 19)
                        Console.WriteLine("Овен");
                    else
                        Console.WriteLine("Телец");
                    break;
                case 5:
                    if (day <= 20)
                        Console.WriteLine("Телец");
                    else
                        Console.WriteLine("Близнецы");
                    break;
                case 6:
                    if (day <= 20)
                        Console.WriteLine("Близнецы");
                    else
                        Console.WriteLine("Рак");
                    break;
                case 7:
                    if (day <= 22)
                        Console.WriteLine("Рак");
                    else
                        Console.WriteLine("Лев");
                    break;
                case 8:
                    if (day <= 22)
                        Console.WriteLine("Лев");
                    else
                        Console.WriteLine("Дева");
                    break;
                case 9:
                    if (day <= 22)
                        Console.WriteLine("Дева");
                    else
                        Console.WriteLine("Весы");
                    break;
                case 10:
                    if (day <= 22)
                        Console.WriteLine("Весы");
                    else
                        Console.WriteLine("Скорпион");
                    break;
                case 11:
                    if (day <= 21)
                        Console.WriteLine("Скорпион");
                    else
                        Console.WriteLine("Стрелец");
                    break;
                case 12:
                    if (day <= 21)
                        Console.WriteLine("Стрелец");
                    else
                        Console.WriteLine("Козерог");
                    break;

                default:
                    Console.WriteLine("Введите нормальную дату");
                    break;
            }

            Console.Read();
        }
    }
}
