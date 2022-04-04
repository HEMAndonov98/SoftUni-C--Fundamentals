using System;

namespace _2.CenterPoint
{
//    You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2, and Y2.Create a method
//that prints the point that is closest to the center of the coordinate system (0, 0) in the format(X, Y). If the points are
//at the same distance from the center, print only the first one.
    class Program
    {
        static void Main(string[] args)
        {            
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            ClosestPoint(x1, y1, x2, y2);
        }

        static void ClosestPoint(double x1, double y1, double x2, double y2)
        {
            double firstPoint = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double secondPoint = Math.Pow(x2, 2) + Math.Pow(y2, 2);

            if (firstPoint <= secondPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
