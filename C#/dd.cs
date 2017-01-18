using System;

namespace radiotex
{
    class Program
    {
        static bool IsD(string str)
        {
            for (int i = 0; i < str.Length; i++)
                if (!(str[i] == '0') && !(str[i] == '1') && !(str[i] == ','))
                    return false;

            return true;
        }
        static void Main(string[] args)
        {

            IsD("0123123"); // False
            IsD("111100000,,1"); //True
            Console.ReadKey();
        }
    }
}
