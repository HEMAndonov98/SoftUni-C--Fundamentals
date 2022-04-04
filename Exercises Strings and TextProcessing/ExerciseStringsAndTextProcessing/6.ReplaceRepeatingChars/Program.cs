using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            List<char> output = new List<char>(word.ToList());

            for (int i = 0; i < output.Count - 1; i++)
            {
                if (output[i] == output[i + 1])
                {
                    output.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join(string.Empty, output));
        }
    }
}
