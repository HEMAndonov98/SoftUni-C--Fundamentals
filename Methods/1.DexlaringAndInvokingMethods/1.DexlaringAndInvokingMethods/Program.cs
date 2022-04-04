using System;

namespace _1.DexlaringAndInvokingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number {num} is {NumberSign(num)}");
        }

        static string NumberSign(int num)
        {

            string placeholder = string.Empty;

            if (num > 0)
            {
              return  placeholder = "positive.";
            }
            else if (num < 0)
            {
              return  placeholder = "negative.";
            }
            else
            {
               return placeholder = "zero.";
            }
        }
    }
}
