﻿using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n ; i++)
           {
                int sum = 0;
                int currentNum = i;

                while (currentNum > 0)
                {
                    sum += currentNum % 10;
                    currentNum = currentNum / 10;
                }
               bool IsSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {IsSpecial}");
            }
        }
    }
}
