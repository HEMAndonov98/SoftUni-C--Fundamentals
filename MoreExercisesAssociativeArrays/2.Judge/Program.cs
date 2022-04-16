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

            //The key is the contestants name and the value is his/her's totalPoints.
            Dictionary<string, int> users = new Dictionary<string, int>();

            AddContest(contests);
            AddIndividualUsers(users, contests);
            PrintContestData(contests);
            PrintIndividualsData(users);
            
            
        }

        static void AddContest(Dictionary<string, Dictionary<string, int>> contests)
        {
            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string username = tokens[0];
                string contestName = tokens[1];
                int points = int.Parse(tokens[2]);

                //If there is no contest with this name we add it and initialize it's dictionary(participants -> points)
                if (!contests.ContainsKey(contestName))
                {
                    contests[contestName] = new Dictionary<string, int>();
                }
                //we check if the current user is participating in this contest,
                //and if his current score is better than his previous one
                if (contests[contestName].ContainsKey(username))
                {
                    if (contests[contestName][username] < points)
                    {
                        contests[contestName][username] = points;
                    }
                }

                //We check if a contest with this name exists and if there is a participant with this name.
                //If not we add the participant with his points.
                if (!contests[contestName].ContainsKey(username))
                {
                    contests[contestName][username] = points;
                }

            }
        }

        static void AddIndividualUsers(Dictionary<string, int> users, Dictionary<string, Dictionary<string, int>> contests)
        {

            foreach (var contest in contests)
            {
                Dictionary<string, int> currContestUsers = contest.Value.ToDictionary(x => x.Key, x => x.Value);

                foreach (var contestant in currContestUsers)
                {
                    if (!users.ContainsKey(contestant.Key))
                    {
                        users[contestant.Key] = 0;
                    }

                    users[contestant.Key] += contestant.Value;
                }
            }
        }

        static void PrintContestData(Dictionary<string, Dictionary<string, int>> contests)
        {
            foreach (var contest in contests)
            {
                //We print the contest name and the number of its participants
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                //We create a new Dictionary witch stores all the participants in the current contest,
                //Ordered by the points they have for this contest and then by their names(alphabetical order).
                Dictionary<string, int> orderedContestants = contest.Value
                        .OrderByDescending(x => x.Value)
                        .ThenBy(x => x.Key)
                        .ToDictionary(x => x.Key, x => x.Value);

                int contestantPosition = 1;

                //We print every participant in the contestant Dictionary in the format: "{position}. {username} <::> {points}"
                foreach (var contestant in orderedContestants)
                {
                    Console.WriteLine($"{contestantPosition++}. {contestant.Key} <::> {contestant.Value}");
                }
            }
        }

        static void PrintIndividualsData(Dictionary<string, int> users)
        {
            Console.WriteLine("Individual standings:");

            //We order the Dictionary by it's individuals points and the by their names(alphabetiacl order).
            users = users.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            int userPosition = 1;

            foreach (var user in users)
            {
                Console.WriteLine($"{userPosition++}. {user.Key} -> {user.Value}");
            }

        }
    }
}
