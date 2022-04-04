using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _5.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, double[]> deamons = new SortedDictionary<string, double[]>();

            string input = Console.ReadLine();
            string splitPattern = @"[^,\s]+";

            MatchCollection deamonNames = Regex.Matches(input, splitPattern);

            foreach (Match name in deamonNames)
            {
                string currentName = name.Value;
                int health = GetDeamonHealth(currentName);
                double damage = CalculateDamage(currentName);

                deamons[currentName] = new double[2];
                deamons[currentName][0] = health;
                deamons[currentName][1] = damage;
            }

            foreach (var deamon in deamons)
            {
                Console.WriteLine($"{deamon.Key} - {deamon.Value[0]} health, {deamon.Value[1]:F2} damage");
            }
        }

        static int GetDeamonHealth(string currentName)
        {
            int health = 0;
            foreach (var letter in currentName)
            {
                if (char.IsLetter(letter))
                {
                    health += letter;
                }
            }

            return health;
        }
        static double CalculateDamage(string currentName)
        {
            string deamonDamagePtrn = @"(-|\+)?\d+[.\d+]*";
            string extraArithmeticOppPtrn = @"(\*|/)";
            const int opperator = 2;
            double damage = 0.0;


            MatchCollection dmgNumbers = Regex.Matches(currentName, deamonDamagePtrn);

            damage = dmgNumbers.Cast<Match>().Select(m => double.Parse(m.Value)).Sum();

            MatchCollection extraSymbols = Regex.Matches(currentName, extraArithmeticOppPtrn);

            if (extraSymbols.Count > 0)
            {
                foreach (Match symbol in extraSymbols)
                {
                    if (char.Parse(symbol.Value) == '*')
                    {
                        damage *= opperator;
                    }
                    else
                    {
                        damage /= opperator;
                    }
                }
            }
            return damage;
        }
    }
}
