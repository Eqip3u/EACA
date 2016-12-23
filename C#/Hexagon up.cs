using System;

namespace Hexagon
{
    class Program
    {
        static double Line(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
        }
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            var line = Line(x1, x2, y1, y2);

            double hexagon = (3 * Math.Sqrt(3) * Math.Pow(line, 2)) / 2;
            Console.Read();
        }
    }
}
