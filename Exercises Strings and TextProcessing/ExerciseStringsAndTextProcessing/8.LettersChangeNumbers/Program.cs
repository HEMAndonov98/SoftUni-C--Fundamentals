using System;

namespace _8.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            decimal totalSum = 0;

            foreach (var sequence in input)
            {
                totalSum += GetSequenceSum(sequence);
            }

            Console.WriteLine($"{totalSum:F2}");
        }
        static decimal GetSequenceSum(string sequence)
        {
            char firstLetter = sequence[0];
            char lastLetter = sequence[sequence.Length - 1];
            int number = int.Parse(sequence.Substring(1, sequence.Length - 2));

            int firstLetterPosition = GetLetterPosition(firstLetter);
            int lastLetterPosition = GetLetterPosition(lastLetter);
            decimal currentSum = 0m;

            if (firstLetterPosition == -1 || lastLetterPosition == -1)
            {
                return 0m;
            }

            if (char.IsUpper(firstLetter))
            {
                currentSum = (decimal)number / firstLetterPosition;
            }
            else if (char.IsLower(firstLetter))
            {
                currentSum = (decimal)number * firstLetterPosition;
            }

            if (char.IsUpper(lastLetter))
            {
                currentSum -= lastLetterPosition;
            }
            else if (char.IsLower(lastLetter))
            {
                currentSum += lastLetterPosition;
            }

            return currentSum;
        }

        static int GetLetterPosition(char letter)
        {
            if (!char.IsLetter(letter))
            {
                return -1;
            }

            char chCI = char.ToLower(letter);
            return (int)chCI - 96;
        }
    }
}
