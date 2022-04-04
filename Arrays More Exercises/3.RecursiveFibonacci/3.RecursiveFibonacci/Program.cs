using System;

namespace _3.RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(n));
        }

        public static int GetFibonacci(int n)
        {

            int[] fibonacci = new int[n + 1];
            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            return fibonacci[n - 1];
        }
    }
}
