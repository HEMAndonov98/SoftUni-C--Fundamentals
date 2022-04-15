using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Ranking
{
    class ContestRecord
    {
        public ContestRecord()
        {
            this.ParticipatedContests = new Dictionary<string, int>();
            this.TotalPoints = 0;
        }

        public Dictionary<string, int> ParticipatedContests { get; set; }
        public int TotalPoints { get; set; }

        public void AddContest(string contestName, int points)
        {
            if (ParticipatedContests.ContainsKey(contestName))
            {
                if (this.ParticipatedContests[contestName] > points)
                {
                    return;
                }
            }
            
            this.ParticipatedContests[contestName] = points;
            this.TotalPoints += points;
        }

        public void SortContests()
        {
            this.ParticipatedContests = this.ParticipatedContests.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string contestInput;
            string contestName = string.Empty;
            string contestPassword = string.Empty;
            while ((contestInput = Console.ReadLine()) != "end of contests")
            {
                string[] contestArgs = contestInput.Split(':', StringSplitOptions.RemoveEmptyEntries);
                contestName = contestArgs[0];
                contestPassword = contestArgs[1];

                contests[contestName] = contestPassword;
            }

            Dictionary<string, ContestRecord> participants = new Dictionary<string, ContestRecord>();

            string contestCommand;
            while ((contestCommand = Console.ReadLine()) != "end of submissions")
            {
                string[] commandArgs = contestCommand.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                contestName = commandArgs[0];
                contestPassword = commandArgs[1];

                if (!ValidateContest(contests, contestName, contestPassword))
                {
                    continue;
                }

                string contestantName = commandArgs[2];
                int pointsEarned = int.Parse(commandArgs[3]);

                if (!participants.ContainsKey(contestantName))
                {
                    participants[contestantName] = new ContestRecord();
                }
                participants[contestantName].AddContest(contestName, pointsEarned);

            }
            participants = participants.OrderByDescending(p => p.Value.TotalPoints).ToDictionary(p => p.Key, p => p.Value);
            Console.WriteLine($"Best candidate is {participants.First().Key} with total {participants.First().Value.TotalPoints} points.");

            participants = participants.OrderBy(p => p.Key).ToDictionary(p => p.Key, p => p.Value);

            foreach (var participant in participants)
            {
                participant.Value.SortContests();
                Console.WriteLine(participant.Key);
                foreach (var contest in participant.Value.ParticipatedContests)
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }

        static bool ValidateContest(Dictionary<string, string> contests,
            string contestName,
            string contestPassword)
        {
            if (contests.ContainsKey(contestName) && contests[contestName] == contestPassword)
            {
                return true;
            }

            return false;
        }
    }
}
