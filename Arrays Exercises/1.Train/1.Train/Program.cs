using System;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                sum += arr1[i];
            }

            foreach (var item in arr1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\n{sum}");
        }
    }
}
