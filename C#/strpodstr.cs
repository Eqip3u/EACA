using System;

namespace ConsoleApplication36
{
    class Calc
    {
        public string zamena(string str, string podstr)
        {
            string itog;
            if (str.Contains(podstr))
            {
                itog = str += podstr;
                return itog;
            }
            return "Данная строка не имеет (придумай че-нибудь тут ваще) подстроку";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string stroka = Console.ReadLine();
            Console.WriteLine("Введите подстроку");
            string poisk = Console.ReadLine();

            Calc a = new Calc();
            
            string result = a.zamena(stroka, poisk);
            
            Console.WriteLine(result);
            
            Console.ReadKey();
        }
    }
}
