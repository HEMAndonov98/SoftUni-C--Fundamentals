using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            const int minValidLength = 3;
            const int maxValidLength = 16;
            char[] validSymbols = new char[] {'-', '_' };

            usernames = usernames.Where(n => n.Length >= minValidLength && n.Length <= maxValidLength)
                .ToArray();

            List<string> validNames = new List<string>();

            foreach (var name in usernames)
            {
                bool isValid = true;

                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsLetterOrDigit(name[i]) || validSymbols.Contains(name[i]))
                    {
                        continue;
                    }
                    isValid = false;
                    break;

                }

                if (isValid)
                {
                    validNames.Add(name);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validNames));
        }
    }
}
