using System;

namespace _3.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(wordToRemove))
            {
                text = text.Replace(wordToRemove, string.Empty);
            }

            Console.WriteLine(text);
        }
    }
}
