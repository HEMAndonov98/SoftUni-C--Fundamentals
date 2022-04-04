using System;
using System.Linq;

namespace _7.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rawInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sequenceNum = 0;
            int sequenceTimes = 0;
            bool sequenceExists = false;
            int longestsequence = 0;

            for (int i = 0; i < rawInput.Length - 1; i++)
            {
                if (rawInput[i] == rawInput[i + 1])
                {
                    sequenceExists = true;
                    sequenceTimes++;

                    if (sequenceTimes > longestsequence)
                    {
                        longestsequence = sequenceTimes;
                        sequenceNum = rawInput[i];
                    }
                }
                else
                {
                    sequenceTimes = 0;
                }
            }
            if (sequenceExists)
            {
                for (int i = 0; i <= longestsequence; i++)
                {
                    Console.Write($"{sequenceNum} ");
                }
            }
        }
    }
}
