using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _4.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            int n = int.Parse(Console.ReadLine());
            string pattern = @"@(?<planet>[A-Za-z]+)[^@\-!:>]*?:(\d+)[^@\-!:>]*?!(?<attackType>A|D)![^@\-!:>]*?->(\d+)";

            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = DecryptMessage(encryptedMessage);

                Match attackInfo = Regex.Match(decryptedMessage, pattern);

                if (attackInfo.Success)
                {
                    string planetName = attackInfo.Groups["planet"].Value;
                    char attackType = char.Parse(attackInfo.Groups["attackType"].Value);

                    if (attackType == 'A')
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == 'D')
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }
            PrintOutput(attackedPlanets, destroyedPlanets);

        }
        static string DecryptMessage(string encryptedMessage)
        {
            StringBuilder decryptedMessage = new StringBuilder();
            int key = GetDecryptionKey(encryptedMessage);

            foreach (var letter in encryptedMessage)
            {
                char decryptedLetter = (char)(letter - key);
                decryptedMessage.Append(decryptedLetter);
            }

            return decryptedMessage.ToString();
        }
        static int GetDecryptionKey(string encryptedMessage)
        {
            string pattern = "[star]";

            MatchCollection messageInfo = Regex.Matches(encryptedMessage, pattern, RegexOptions.IgnoreCase);
           
            return messageInfo.Count;
        }
        static void PrintOutput(List<string> attackedPlanets, List<string> destroyedPlanets)
        {
            attackedPlanets.Sort();
            destroyedPlanets.Sort();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
            {
                foreach (var planet in attackedPlanets)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (var planet in destroyedPlanets)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
