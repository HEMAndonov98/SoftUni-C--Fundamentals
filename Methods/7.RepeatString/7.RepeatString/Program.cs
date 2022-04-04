using System;
using System.Text;

namespace _7.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int timesRepeated = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(input, timesRepeated));
        }

        static string RepeatString(string input, int timesRepeated)
        {
            var newStr = new StringBuilder();

            for (int i = 0; i < timesRepeated; i++)
            {
                newStr.Append(input);
            }

            return newStr.ToString();
        }
    }
}
