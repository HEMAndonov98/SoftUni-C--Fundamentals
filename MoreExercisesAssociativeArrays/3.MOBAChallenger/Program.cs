using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            string input;
            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains("->"))
                {
                    AddPlayerAndPossition(players, input);
                }
                else if (input.Contains(" vs "))
                {
                    Duel(players, input);
                }
            }
            PrintOutput(players);
        }

        static void AddPlayerAndPossition(Dictionary<string, Dictionary<string , int>> players, string input)
        {
            string [] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            string player = tokens[0];
            string position = tokens[1];
            int skill = int.Parse(tokens[2]);

            if (!players.ContainsKey(player))
            {
                players[player] = new Dictionary<string, int>();
            }

            if (players[player].ContainsKey(position))
            {
                if (players[player][position] < skill)
                {
                    players[player][position] = skill;
                }
            }

            if (!players[player].ContainsKey(position))
            {
                players[player][position] = skill;
            }
        }

        static void Duel(Dictionary<string, Dictionary<string, int>> players, string input)
        {
            string[] tokens = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
            string firstPlayer = tokens[0];
            string secondPlayer = tokens[1];

            if (!players.ContainsKey(firstPlayer) || !players.ContainsKey(secondPlayer))
            {
                return;
            }

            string playerToRemove = string.Empty;
            foreach (var firstPos in players[firstPlayer])
            {
                foreach (var secondPos in players[secondPlayer])
                {
                    if (firstPos.Key == secondPos.Key)
                    {
                        if (players[firstPlayer].Values.Sum() > players[secondPlayer].Values.Sum())
                        {
                            playerToRemove = secondPlayer;
                        }
                        else if (players[secondPlayer].Values.Sum() > players[firstPlayer].Values.Sum())
                        {
                            playerToRemove = firstPlayer;
                        }
                    }
                }
            }
            players.Remove(playerToRemove);

        }

        static void PrintOutput(Dictionary<string, Dictionary<string, int>> players)
        {
            players = players.OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var player in players)
            {
                Console.WriteLine($"{ player.Key}: {player.Value.Values.Sum()} skill");

                Dictionary<string, int> playerPositions = player
                    .Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var position in playerPositions)
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
