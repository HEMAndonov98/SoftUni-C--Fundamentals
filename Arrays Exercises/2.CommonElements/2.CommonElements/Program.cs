using System;

namespace _2.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] arr2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] arr3 = new string[arr2.Length];
            int arr3Index = 0;

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        arr3[arr3Index] = arr2[i];
                        arr3Index++;
                    }
                }
            }

            Console.WriteLine(string.Join(' ', arr3));
        }
    }
}
