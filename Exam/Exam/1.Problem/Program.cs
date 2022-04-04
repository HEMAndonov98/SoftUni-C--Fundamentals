using System;
using System.Linq;
using System.Text;

namespace _1.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Complete")
            {
                string[] commandArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "Make")
                {
                    if (commandArgs[1] == "Upper")
                    {

                        int index = int.Parse(commandArgs[2]);
                        char charToUpper = char.Parse(password.Substring(index, 1).ToUpper());

                        password = password.Remove(index, 1);
                        password = password.Insert(index, charToUpper.ToString());

                        Console.WriteLine(password);
                    }
                    else if (commandArgs[1] == "Lower")
                    {
                        int index = int.Parse(commandArgs[2]);
                        char chToLower = char.Parse(password.Substring(index, 1).ToLower());

                        password = password.Remove(index, 1);
                        password = password.Insert(index, chToLower.ToString());

                        Console.WriteLine(password);
                    }
                }
                else if (commandArgs[0] == "Insert")
                {
                    int index = int.Parse(commandArgs[1]);
                    char ch = char.Parse(commandArgs[2]);

                    if (index < 0 || index >= password.Length)
                    {
                        continue;
                    }

                    password = password.Insert(index, ch.ToString());
                    Console.WriteLine(password);
                }
                else if (commandArgs[0] == "Replace")
                {
                    char ch = char.Parse(commandArgs[1]);
                    int value = ch + int.Parse(commandArgs[2]);

                    password = password.Replace(ch, (char)value);

                    Console.WriteLine(password);
                }
                else if (commandArgs[0] == "Validation")
                {
                    ValidatePassword(password);
                }
            }
        }

        static void ValidatePassword(string password)
        {

            if (password.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long!");
            }

            foreach (var character in password)
            {
                if (char.IsLetterOrDigit(character) || password.Contains('_'))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters, digits and _!");
                }
            }

            if (!password.Any(char.IsUpper))
            {
                Console.WriteLine("Password must consist at least one uppercase letter!");
            }

            if (!password.Any(char.IsLower))
            {
                Console.WriteLine("Password must consist at least one lowercase letter!");
            }

            if (!password.Any(char.IsDigit))
            {
                Console.WriteLine("Password must consist at least one digit!");
            }
            
        }
    }
}
