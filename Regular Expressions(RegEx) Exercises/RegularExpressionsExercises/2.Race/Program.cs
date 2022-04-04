using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> raceStats = new Dictionary<string, int>();

            string[] participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var partiipant in participants)
            {
                raceStats[partiipant] = 0;
            }

            string input;
            
            while ((input = Console.ReadLine()) != "end of race")
            {
                ProcessInput(raceStats, input);
            }

            raceStats = raceStats.OrderByDescending(s => s.Value)
                .ToDictionary(s => s.Key, s => s.Value);

            participants = raceStats.Select(x => x.Key).ToArray();

            string[] places = new string[] { "st", "nd", "rd" };


            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine($"{i + 1}{places[i]} place: {participants[i]}");
            }
        }

        static void ProcessInput(Dictionary<string, int> raceStats, string input)
        {
            string namePattern = "[A-Za-z]";
            string distanceRanPattern = @"\d";

            MatchCollection mName = Regex.Matches(input, namePattern);
            MatchCollection mDistance = Regex.Matches(input, distanceRanPattern);

            char[] letters = mName.Cast<Match>().Select(l => char.Parse(l.Value)).ToArray();
            string name = new string(letters);

            if (raceStats.ContainsKey(name))
            {
                raceStats[name] += mDistance.Cast<Match>().Select(d => int.Parse(d.Value)).Sum();
            }
        }
    }
}
