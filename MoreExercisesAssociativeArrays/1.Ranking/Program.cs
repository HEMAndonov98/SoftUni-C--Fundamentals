using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            AddContests(contests);

            Dictionary<string, Dictionary<string, int>> submissions = new Dictionary<string, Dictionary<string, int>>();
            AddSubmissions(submissions, contests);
            
            PrintBestCandidate(submissions);
            PrintRanking(submissions);
        }
        static void AddContests(Dictionary<string, string> contests)
        {
            string input;
            string[] tokens;
            string contestName;
            string contestPass;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                tokens = input.Split(':', StringSplitOptions.RemoveEmptyEntries);
                contestName = tokens[0];
                contestPass = tokens[1];

                if (!contests.ContainsKey(contestName))
                {
                    contests[contestName] = contestPass;
                }
            }
        }

        static void AddSubmissions(Dictionary<string, Dictionary<string, int>> submissions, Dictionary<string, string> contests)
        {
            string input;
            string[] tokens;
            string contestName;
            string contestPass;

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                tokens = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                contestName = tokens[0];
                contestPass = tokens[1];

                if (!contests.ContainsKey(contestName) || contests[contestName] != contestPass)
                {
                    continue;
                }

                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                AddSubmission(username, contestName, points, submissions);
            }
        }

        static void AddSubmission(string username, string contestName, int points, Dictionary<string, Dictionary<string, int>> submissions)
        {
            if (!submissions.ContainsKey(username))
            {
                submissions[username] = new Dictionary<string, int>();
            }

            if (submissions[username].ContainsKey(contestName))
            {
                if (submissions[username][contestName] < points)
                {
                    submissions[username][contestName] = points;
                }
            }

            if (!submissions[username].ContainsKey(contestName))
            {
                submissions[username][contestName] = points;
            }
        }

        static void PrintBestCandidate(Dictionary<string, Dictionary<string, int>> submissions)
        {
            string bestCandidate = string.Empty;
            int mostPoints = 0;

            foreach (var submission in submissions)
            {
                //The Value of the Dictionary is another dictionary with <string, int> KVP, here we take i'ts values and sum them.
                int currCandidateMaxPoints = submission.Value.Values.Sum(); 

                if (currCandidateMaxPoints > mostPoints)
                {
                    mostPoints = currCandidateMaxPoints;
                    //The keyValue is the candidates username.
                    bestCandidate = submission.Key; 
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {mostPoints} points.");
        }

        static void PrintRanking(Dictionary<string, Dictionary<string, int>> submissions)
        {
            Console.WriteLine("Ranking:");

            submissions = submissions.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);
            foreach (var submission in submissions)
            {
                Dictionary<string, int> contests = submission.Value.OrderByDescending(c => c.Value).ToDictionary(c => c.Key, c => c.Value);
                //submission.Key is the username of the candidate
                Console.WriteLine(submission.Key);

                foreach (var contest in contests)
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }

    }
}
