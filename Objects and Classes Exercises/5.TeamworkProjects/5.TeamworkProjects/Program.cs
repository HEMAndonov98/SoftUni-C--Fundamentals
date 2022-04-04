using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.TeamworkProjects
{
    class Team
    {
        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
            this.Members = new List<string>();
        }

        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public void AddMember(string member)
        {
            this.Members.Add(member);
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Team> teams = new List<Team>();
            int teamCount = int.Parse(Console.ReadLine());

            RegisterTeam(teams, teamCount);
            AddMembers(teams);

            List<Team> teamsWithNoMembers = teams.Where(t => t.Members.Count == 0).ToList();
            teamsWithNoMembers = teamsWithNoMembers.OrderBy(t => t.Name).ToList();

            List<Team> teamsWithMembers = teams.Where(t => t.Members.Count > 0).ToList();
            teamsWithMembers = teamsWithMembers.OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name).ToList();

            foreach (var team in teamsWithMembers)
            {
                Console.WriteLine($"{team.Name}{Environment.NewLine}" +
                    $"- {team.Creator}");

                foreach (string member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in teamsWithNoMembers)
            {
                Console.WriteLine(string.Join(Environment.NewLine, team));
            }
        }

        static void RegisterTeam(List<Team> teams, int teamCount)
        {
            for (int i = 0; i < teamCount; i++)
            {
                string[] teamArgs = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries);

                string teamCreator = teamArgs[0];
                string teamName = teamArgs[1];


                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(t => t.Creator == teamCreator))
                {
                    Console.WriteLine($"{teamCreator} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team(teamName, teamCreator);
                teams.Add(newTeam);

                Console.WriteLine($"Team {newTeam.Name} has been created by {newTeam.Creator}!");
            }
        }

        static void AddMembers(List<Team> teams)
        {
            string rawInput;


            while ((rawInput = Console.ReadLine()) != "end of assignment")
            {
                string[] teamComands = rawInput
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);
                string user = teamComands[0];
                string teamName = teamComands[1];

                Team searchedTeam = teams.FirstOrDefault(t => t.Name == teamName);

                if (searchedTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(t => t.Members.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                if (teams.Any(t => t.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                searchedTeam.AddMember(user);

            }
        }
    }
}
