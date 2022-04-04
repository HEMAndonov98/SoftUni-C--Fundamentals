using System;

namespace _9.PeliodromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                IsPaliodromeInt(input);
            }
        }

        static void IsPaliodromeInt(string input)
        {

            for (int i = 0; i < input.Length; i++)
            {

                for (int j = input.Length - (i + 1); j >= 1; j--)
                {
                    if (input[i] == input[j])
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }
                Console.WriteLine("true");
        }
    }
}
