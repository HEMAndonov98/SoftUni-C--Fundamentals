using System;

namespace _6.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(GetRectangleArea(width, height));
        }

        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
