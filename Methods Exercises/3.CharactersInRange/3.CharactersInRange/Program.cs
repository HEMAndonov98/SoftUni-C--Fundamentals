using System;

namespace _3.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());

            GetAllCharatersBetween(firstLetter, secondLetter);
        }

        static void GetAllCharatersBetween(char firstLetter, char secondLetter)
        {
        
            if (firstLetter < secondLetter)
            {
                for (int currentLetter = firstLetter + 1; currentLetter < secondLetter; currentLetter++)
                {
                    Console.Write($"{(char)currentLetter} ");
                }
            }
            else
            {
                for (int currentLetter = secondLetter + 1; currentLetter < firstLetter; currentLetter++)
                {
                    Console.Write($"{(char)currentLetter} ");
                }
            }
        }
    }
}
