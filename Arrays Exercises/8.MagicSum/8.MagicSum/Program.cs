using System;
using System.Linq;

namespace _8.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int magicNum = int.Parse(Console.ReadLine()); //this is the condition num so that a pair of numbers from the array are unique

            //This is where I select the first number that ill be summing
            for (int i = 0; i < numbersArr.Length; i++)
            {
                //here I sum the first num with its adjasent number from the array
                for (int j = i + 1; j < numbersArr.Length; j++)
                {
                    int sum = numbersArr[i] + numbersArr[j];
                    //test to see if the condition is met
                    if (sum == magicNum)
                    {
                        Console.WriteLine($"{numbersArr[i]} {numbersArr[j]}");
                    }
                }
            }
        }
    }
}
