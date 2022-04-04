using System;

namespace _2.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string firstName = names[0];
            string secondName = names[1];
            int totalSum = 0;
            int startIndex = 0;

            for (int i = 0; i < Math.Min(firstName.Length, secondName.Length); i++)
            {
                startIndex = i;
                totalSum += firstName[i] * secondName[i];
            }


            if (firstName.Length > secondName.Length)
            {
                totalSum += GetRemainingLetterVallues(startIndex, firstName);
            }
            else if(secondName.Length > firstName.Length)
            {
                totalSum += GetRemainingLetterVallues(startIndex, secondName);
            }

            Console.WriteLine(totalSum);
        }

        static int GetRemainingLetterVallues(int startIndex, string longerName)
        {
            string remainingLetters = longerName.Substring(startIndex + 1);
            int remainingValues = 0;

            for (int i = 0; i < remainingLetters.Length; i++)
            {
                remainingValues += remainingLetters[i];
            }
            return remainingValues;
        }
    }
}
