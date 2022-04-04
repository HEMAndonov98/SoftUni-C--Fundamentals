using System;

namespace _10.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsDivisible(i) == true && HasOddDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsDivisible(int i)
        {
            int numSum = 0;
            int currentNum = i;

            while (currentNum > 0)
            {
                numSum += currentNum % 10;
                currentNum /= 10;
            }

            if (numSum % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool HasOddDigit(int i)
        {
            int num = 0;
            int currentNum = i;

            while (currentNum > 0)
            {
                num = currentNum % 10;

                if (num % 2 != 0)
                {
                    return true;
                }

                currentNum /= 10;
            }
            return false;
        }
    }
}
