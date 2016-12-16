using System;

namespace Sequence
{
    class MainClass
    {
        static void Main(string[] args)
        {
            char userChar = char.Parse(Console.ReadLine());
            string userStr = Console.ReadLine();

            Console.WriteLine(userStr.Replace(' ', userChar));
            Console.Read();
        }
    }
}
