using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            //The key is the contestName and the value is it's participants(contestants).
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> users = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string username = tokens[0];
                string contestName = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!contests.ContainsKey(contestName))
                {
                    contests[contestName] = new Dictionary<string, int>();
                }

                if (contests[contestName].ContainsKey(username))
                {
                    if (contests[contestName][username] < points)
                    {
                        contests[contestName][username] = points;
                    }
                }

                if (!contests[contestName].ContainsKey(username))
                {
                    contests[contestName][username] = points;
                }

            }

            foreach (var contest in contests)
            {
                Dictionary<string, int> contestParticipants = contest.Value.ToDictionary(x => x.Key, x => x.Value);

                foreach (var contestant in contestParticipants)
                {
                    if (!users.ContainsKey(contestant.Key))
                    {
                        users[contestant.Key] = 0;
                    }

                    users[contestant.Key] += contestant.Value;
                }

                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                int position = 1;

                Dictionary<string, int> contestants = contest.Value
                        .OrderByDescending(x => x.Value)
                        .ThenBy(x => x.Key)
                        .ToDictionary(x => x.Key, x => x.Value);

                foreach (var contestant in contestants)
                {
                    Console.WriteLine($"{position++}. {contestant.Key} <::> {contestant.Value}");
                }
            }


            Console.WriteLine("Individual standings:");

            users = users.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            int position2 = 1;

            foreach (var user in users)
            {
                Console.WriteLine($"{position2++}. {user.Key} -> {user.Value}");
            }
        }
    }
}
