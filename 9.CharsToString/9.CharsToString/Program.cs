using System;
using System.Text;

namespace _9.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentance = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                char charachter = char.Parse(Console.ReadLine());
                sentance.Append(charachter);
            }
            Console.WriteLine(sentance);
        }
    }
}
