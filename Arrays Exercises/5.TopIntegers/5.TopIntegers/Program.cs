using System;
using System.Linq;

namespace _5.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rawInput = Console.ReadLine()
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();


            for (int i = 0; i < rawInput.Length; i++)
            {
                bool isTopInt = true;
                for (int j = i + 1; j < rawInput.Length; j++)
                {
                    if (rawInput[i] <= rawInput[j])
                    {
                        isTopInt = false;
                        break;
                    }
                    
                }

                if (isTopInt)
                {
                    Console.Write(rawInput[i] + " ");
                }
            }

        }
    }
}
