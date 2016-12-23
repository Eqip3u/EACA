using System;

namespace Hexagon
{
    class Program
    {
        static double Line(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
        }
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double xCenter = double.Parse(Console.ReadLine());
            double yCenter = double.Parse(Console.ReadLine());

            double hypotenuseOfTriangle = Line(xCenter, yCenter, x1, y1); // Находим гипотенузу треугольника вложенного в хексагон
            double cathetusOfTriangle = hypotenuseOfTriangle / 2; // Катет треугольника (половина длинны ребра хексагона)
            double apothem = Math.Sqrt(Math.Pow(hypotenuseOfTriangle, 2) - Math.Pow(cathetusOfTriangle, 2)); // Находим арофему треугольника

            double perimeterOfHexagod = (2 * cathetusOfTriangle) * 6; // Периметр хексагона вычисляется ( (катет треугольника * 2) * 6 (ребер хексагона) ) 

            double areaOfHexagon = (1 / 2) * perimeterOfHexagod * apothem; // Площадь хексагона вычисляется по формуле ((1/2) * периметр хексагона * апофему)

            Console.Read();
        }
    }
}
