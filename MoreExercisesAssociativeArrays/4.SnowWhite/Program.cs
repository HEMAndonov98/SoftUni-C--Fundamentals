using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.SnowWhite
{
    class Dwarf
    {
        public Dwarf(string name, string color, int physics)
        {
            this.Name = name;
            this.HatColor = color;
            this.Physics = physics;
        }

        public string Name { get; set; }
        public string HatColor { get; set; }
        public int Physics { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();

            string input;

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] tokens = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                string dwarfName = tokens[0];
                string dwarfHatColor = tokens[1];
                int dwarfPhysics = int.Parse(tokens[2]);

                if (!dwarfs.ContainsKey(dwarfHatColor))
                {
                    dwarfs[dwarfHatColor] = new Dictionary<string, int>();
                }

                if (dwarfs[dwarfHatColor].ContainsKey(dwarfName))
                {
                    if (dwarfs[dwarfHatColor][dwarfName] < dwarfPhysics)
                    {
                        dwarfs[dwarfHatColor][dwarfName] = dwarfPhysics;
                    }
                }

                if (!dwarfs[dwarfHatColor].ContainsKey(dwarfName))
                {
                    dwarfs[dwarfHatColor][dwarfName] = dwarfPhysics;
                }
            }

            dwarfs = dwarfs
                .OrderByDescending(x => x.Value.Values.Max())
                .ThenByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            List<Dwarf> result = new List<Dwarf>();

            foreach (var kvp in dwarfs)
            {
                Dictionary<string, int> currentDwarves = kvp.Value;
      

                foreach (var dwarf in currentDwarves)
                {
                    //Console.WriteLine($"({kvp.Key}) {dwarf.Key} <-> {dwarf.Value}");

                    string name = dwarf.Key;
                    string color = kvp.Key;
                    int physics = dwarf.Value;

                    result.Add(new Dwarf(name, color, physics));
                }
            }

            result = result.OrderByDescending(x => x.Physics).ToList();

            foreach (var dwarf in result)
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");

            }
        }
    }
}

