using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.DrumSet
{
//    Gabsy is Orgolt&#39;s Final Revenge charming drummer. She has a drum set but the different drums have different
//origins – some she bought, some are gifts, so they are all of different quality.Every day she practices on each of
//them, so she does damage and reduces the drum`s quality.Sometimes a drum breaks, so she needs to buy a new
//one.Help her keep her drum set organized.
//You will receive Gabsy&#39;s savings, the money she can spend on new drums. Next, you will receive a sequence of
//integers, which represents the initial quality of each drum in Gabsy&#39;s drum set.
//Until you receive the command &quot;Hit it again, Gabsy!&quot;, you will be receiving an integer: the hit power Gabsy
//applies on each drum while practicing.When the power is applied, you should decrease the value of the drum&#39;s
//quality with the current power.
//When a certain drum reaches 0 quality, it breaks.Then Gabsy should buy a replacement.She needs to buy the same
//model.Therefore, its quality will be the same as the initial quality of the broken drum.The price is calculated by the
//formula: { initialQuality} * 3. Gabsy will always replace her broken drums until the moment she can no longer afford
// them.If she doesn&#39;t have enough money for a replacement, the broken drum is removed from the drum set.
//When you receive the command &quot; Hit it again, Gabsy!&quot;, the program ends and you should print the current
// state of the drum set.On the second line, you should print the remaining money in Gabsy&#39;s savings account.

    class Program
    {
        static void Main(string[] args)
        {
            decimal savings = decimal.Parse(Console.ReadLine());

            //here we add the quality of each drum set(reference for the price of a new drum set)
            List<int> initialDrumSet = Console.ReadLine() 
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> currentDrumSet = new List<int>(initialDrumSet); //these are the drum sets we'll be working with

            string input;
            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < currentDrumSet.Count; i++)
                {
                    currentDrumSet[i] -= hitPower;

                    if (currentDrumSet[i] <= 0) // We check if a drum set is broken
                    {
                        decimal price = initialDrumSet[i] * 3;

                        if (price > savings) //If we don't have enough money to replace the set we disgard it with its initial price reference.
                        {
                            currentDrumSet.RemoveAt(i);
                            initialDrumSet.RemoveAt(i);
                            i--;
                        }
                        else
                        {
                            savings -= price;
                            currentDrumSet[i] = initialDrumSet[i];
                        }
                    }
                }
            }

            if (currentDrumSet.Count > 0)
            {
                Console.WriteLine(string.Join(' ', currentDrumSet));
            }
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
