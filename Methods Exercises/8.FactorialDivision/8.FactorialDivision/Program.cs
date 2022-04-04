using System;

namespace _8.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());



            double result = (double)GetFactorial(firstNum) / (double)GetFactorial(secondNum);

            Console.WriteLine($"{result:F2}");
        }

        static long GetFactorial(int number)
        {
            long factorial = (long)number;

            for (int i = number; i > 1; i--)
            {
                factorial *= i - 1;
            }

            return factorial;
        }
    }
}
