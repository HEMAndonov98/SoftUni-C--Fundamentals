using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.DragonArmy
{

    class Program
    {
        static void Main(string[] args)
        {
            Execute();
        }

        public static Dictionary<string, List<Dragon>> SortDragons(Dictionary<string, List<Dragon>> dragonStats)
        {
            Dictionary<string, List<Dragon>> sortedDragonStats = new Dictionary<string, List<Dragon>>();

            foreach (var type in dragonStats)
            {
                List<Dragon> sortedDragons = dragonStats[type.Key]
                    .OrderBy(x => x.Name)
                    .ToList();

                sortedDragonStats[type.Key] = sortedDragons;
            }

            return sortedDragonStats;
        }
        public static void PrintOutput(Dictionary<string, List<Dragon>> dragonStats)
        {
            foreach (var kvp in dragonStats)
            {
                Console.WriteLine($"{kvp.Key}::({kvp.Value.Average(x => x.Damage):F2}/{kvp.Value.Average(x => x.Health):F2}/{kvp.Value.Average(x => x.Armor):F2})");

                foreach (var dragon in kvp.Value)
                {
                    Console.WriteLine(dragon);
                }
            }
        }
        public static void AddDragon(Dictionary<string, List<Dragon>> dragonStats, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = tokens[0];
                string name = tokens[1];
                string damage = tokens[2];
                string health = tokens[3];
                string armor = tokens[4];

                if (!dragonStats.ContainsKey(type))
                {
                    dragonStats[type] = new List<Dragon>();
                }
                var selectedDragon = dragonStats[type].FirstOrDefault(x => x.Name == name);

                if (selectedDragon != null)
                {
                    selectedDragon.ChangeStats(damage, health, armor);
                }
                else
                {
                    var newDragon = new Dragon(name, damage, health, armor);
                    dragonStats[type].Add(newDragon);
                }
            }
        }
        public static void Execute()
        {
            Dictionary<string, List<Dragon>> dragonStats = new Dictionary<string, List<Dragon>>();
            int n = int.Parse(Console.ReadLine());

            AddDragon(dragonStats, n);
            dragonStats = SortDragons(dragonStats);
            PrintOutput(dragonStats);
        }
    }
}
