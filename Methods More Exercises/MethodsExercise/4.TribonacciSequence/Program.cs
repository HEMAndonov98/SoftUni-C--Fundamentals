using System;

namespace _4.TribonacciSequence
{
//    In the &quot;Tribonacci&quot; sequence, every number is formed by the sum of the previous 3.
//You are given a number num.Write a program that prints num numbers from the Tribonacci sequence, each on a
//new line, starting from 1. The input comes as a parameter named num.The value num will always be a positive
//integer.
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            TribonacciSequence(num);

        }

        static void TribonacciSequence(int num)
        {
            int currentNum = 0;

            int firstNum = 1;
            int secondNum = 1;
            int thirdNum = 2;

            for (int i = 1; i <= num ; i++)
            {
                if (i == 1)
                {
                    Console.Write("{0} ", firstNum);
                }
                else if (i == 2)
                {
                    Console.Write("{0} ", secondNum);
                }
                else if (i == 3)
                {
                    Console.Write("{0} ", thirdNum);
                }
                else
                {
                    currentNum = thirdNum + secondNum + firstNum;

                    firstNum = secondNum;
                    secondNum = thirdNum;
                    thirdNum = currentNum;

                    Console.Write("{0} ", currentNum);
                }
            }
        }
    }
}
