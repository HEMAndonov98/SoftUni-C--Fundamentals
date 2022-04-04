using System;

namespace _6.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int openingBrackets = 0;
            int closingBrackets = 0;
            bool unbalanced = false;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                char bracket = '\0';
                bool Isbracket = char.TryParse(input, out bracket);

                if (bracket == '(')
                {
                    openingBrackets++;
                }
                else if (bracket == ')')
                {
                    closingBrackets++;
                }

                if (openingBrackets > closingBrackets + 1 || closingBrackets > openingBrackets)
                {
                    Console.WriteLine("UNBALANCED");
                    unbalanced = true;
                    break;
                }


             
            }

            if (openingBrackets == closingBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else if (openingBrackets != closingBrackets && !unbalanced)
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
