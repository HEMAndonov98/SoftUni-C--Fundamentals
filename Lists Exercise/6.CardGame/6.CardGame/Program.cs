using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOneHand = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> playerTwoHand = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            int i = 0;

            
            while (playerOneHand.Count > 0 && playerTwoHand.Count > 0)
            {
                if (playerOneHand[i] > playerTwoHand[i])
                {
                    playerOneHand.Add(playerOneHand[i]);
                    playerOneHand.Add(playerTwoHand[i]);
                    playerOneHand.RemoveAt(i);
                    playerTwoHand.RemoveAt(i);
                }
                else if (playerTwoHand[i] > playerOneHand[i])
                {
                    playerTwoHand.Add(playerTwoHand[i]);
                    playerTwoHand.Add(playerOneHand[i]);
                    playerTwoHand.RemoveAt(i);
                    playerOneHand.RemoveAt(i);
                }
                else if (playerOneHand[i] == playerTwoHand[i])
                {
                    playerOneHand.RemoveAt(i);
                    playerTwoHand.RemoveAt(i);
                }

               
            }

            string winingPlayer = string.Empty;
            int sum = 0;

            if (playerOneHand.Count == 0)
            {
                winingPlayer = "Second";
                sum = playerTwoHand.Sum();
            }
            else if (playerTwoHand.Count == 0)
            {
                winingPlayer = "First";
                sum = playerOneHand.Sum();
            }

            Console.WriteLine($"{winingPlayer} player wins! Sum: {sum}");
        }
    }
}
