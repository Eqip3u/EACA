using System;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var s0 = Console.ReadLine();

            Console.WriteLine((s.Length - s.Replace(s0, "").Length) / s0.Length);
            // либо сложным способом через регулярку new Regex(pattern).Matches(source).Count;
            Console.Read();
        }
    }
}
