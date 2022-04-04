using System;

namespace cSharpExercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int factorial, sum = 0;

            //So I can loop through every digit in the number
            for (int i = a; i > 0; i /= 10)
            {

                factorial = 1;
                //this iterates through the number itself example 145 % 10 = 14.{5}-this is the number im factorializing
                for (int j = 1; j <= i % 10; j++)
                {
                    //strong number formula
                    factorial = factorial * j;

                }
                sum += factorial;
            }

            if (sum == a)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
