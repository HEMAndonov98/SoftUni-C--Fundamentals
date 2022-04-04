using System;

namespace _3.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            const double epsilon = 0.000001f;

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            bool isEqual = Math.Abs(a - b) < epsilon;

            Console.WriteLine(isEqual);
        }

        
        
    }
}
