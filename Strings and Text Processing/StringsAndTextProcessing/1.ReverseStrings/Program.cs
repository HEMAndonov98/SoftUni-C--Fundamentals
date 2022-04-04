using System;
using System.Text;

namespace _1.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string word = input;
                StringBuilder sb = new StringBuilder();

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    sb.Append(word[i]);
                }
                string reversedWord = sb.ToString();

                Console.WriteLine($"{word} = {reversedWord}");
            }
        }
    }
}
