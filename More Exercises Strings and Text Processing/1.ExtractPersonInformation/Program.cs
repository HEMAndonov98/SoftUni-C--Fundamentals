using System;
using System.Text.RegularExpressions;

namespace _1.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string namePtrn = @"@(\w+)\|";
            string agePtrn = @"#(\d+)\*";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match name = Regex.Match(input, namePtrn);
                Match age = Regex.Match(input, agePtrn);

                Console.WriteLine($"{name.Groups[1]} is {age.Groups[1]} years old.");
            }
        }
    }
}
