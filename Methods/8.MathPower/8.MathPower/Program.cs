using System;

namespace _8.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToThePower(@base, power));
        }

        static double RaiseToThePower(double @base, double power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= @base;
            }

            return result;
        }
    }
}
