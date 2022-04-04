using System;
using System.Linq;

namespace _4.PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            IsPasswordValid(input);
        }

        static void IsPasswordValid(string input)
        {
            bool isValidPassword = true;


            if (!PasswordLengthCheck(input))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValidPassword = false;
            }

            if (DoesContainSpecialSymbols(input))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValidPassword = false;
            }

            if (!DigitCheck(input))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValidPassword = false;
            }

            if (isValidPassword)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool PasswordLengthCheck(string input)
        {
            if (input.Length >= 6 && input.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool DoesContainSpecialSymbols(string input)
        {
            string specialSymbols ="`~,<.>/?\\|'\";:]}[{=+-_)(*&^%$#@!±§";
            bool hasSpecialSymbol = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (specialSymbols.Contains(input[i]))
                {
                    hasSpecialSymbol = true;
                }
                
            }

            return hasSpecialSymbol;
        }

        static bool DigitCheck(string input)
        {
            int digitCounter = 0;
            bool doesContainDigits = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digitCounter++;
                    if (digitCounter >= 2)
                    {
                        doesContainDigits = true;
                        break;
                    }
                }
            }

            return doesContainDigits;
        }
    }
}
