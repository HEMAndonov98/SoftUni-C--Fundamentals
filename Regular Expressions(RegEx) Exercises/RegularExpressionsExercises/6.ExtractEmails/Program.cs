using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _6.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> emails = new List<string>();

            string input = Console.ReadLine();
            string searchPattern = @"[\w.\-]+@[\w.\-]+\.[\w/-]+";

            MatchCollection foundEmails = Regex.Matches(input, searchPattern);
            string validationPattern = @"^[A-Za-z0-9]+[A-Za-z0-9._\-]+@[A-Za-z][A-Za-z.\-]+\.[A-Za-z.\-]+[A-Za-z]$";

            foreach (Match email in foundEmails)
            {
                Match validEmail = Regex.Match(email.ToString(), validationPattern);

                if (validEmail.Success)
                {
                    emails.Add(validEmail.ToString());
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, emails));
        }
    }
}
