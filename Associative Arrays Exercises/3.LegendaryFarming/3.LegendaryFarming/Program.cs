using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                { "shards", 0 },
                { "motes", 0 },
                { "fragments", 0 }
            };
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            string itemObtained = string.Empty;

            while (string.IsNullOrEmpty(itemObtained))
            {
                string[] materialsArgs = Console.ReadLine()
                    .ToLower()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();


                ProcessMaterials(keyMaterials, junkMaterials, materialsArgs, ref itemObtained);
            }

            PrintMaterials(keyMaterials, junkMaterials, itemObtained);
        
        }

        static void ProcessMaterials(Dictionary<string, int> keyMaterials,
            Dictionary<string, int> junkMaterials,
            string[] materialsArgs,
            ref string itemObtained)
        {
            Dictionary<string, string> itemsTable = new Dictionary<string, string>()
            {
                { "shards", "Shadowmourne" },
                { "fragments", "Valanyr" },
                { "motes", "Dragonwrath" }
            };

            for (int i = 0; i < materialsArgs.Length; i += 2)
            {
                int materialQty = int.Parse(materialsArgs[i]);
                string materialName = materialsArgs[i + 1];

                if (keyMaterials.ContainsKey(materialName))
                {
                    keyMaterials[materialName] += materialQty;

                    if (keyMaterials[materialName] >= 250)
                    {
                        keyMaterials[materialName] -= 250;
                        itemObtained = itemsTable[materialName];
                        break;
                    }
                }
                else
                {
                    if (!junkMaterials.ContainsKey(materialName))
                    {
                        junkMaterials[materialName] = 0;
                    }

                    junkMaterials[materialName] += materialQty;
                }
            }
        }

        static void PrintMaterials(Dictionary<string, int> keyMaterials,
            Dictionary<string, int> junkMaterials,
            string itemObtained
            )
        {
            Console.WriteLine($"{itemObtained} obtained!");

            foreach (var kvp in keyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junkMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }

}    

