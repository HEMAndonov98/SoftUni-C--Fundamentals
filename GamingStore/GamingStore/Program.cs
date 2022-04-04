using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double total = 0.0;
            string[] gamesArr = {"OutFall 4", "CS: OG", "Zplinter Zell", "Honored 2", "RoverWatch", "RoverWatch Origins Edition"};
            string input = Console.ReadLine();
            bool isOutOfMoney = false;



            while (input != "Game Time")
            {
                bool isValidGame = Array.Exists(gamesArr, x => x == input);

                if (!isValidGame)
                {
                    Console.WriteLine("Not Found");
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    switch (input)
                    {
                        case "OutFall 4":
                            if (balance < 39.99)
                            {
                                Console.WriteLine("Too Expensive");
                                input = Console.ReadLine();
                                continue;
                            }
                            else
                            {
                                balance -= 39.99;
                                total += 39.99;
                                Console.WriteLine($"Bought {input}");
                            }
                            break;
                        case"CS: OG":
                            if (balance < 15.99)
                            {
                                Console.WriteLine("Too Expensive");
                                input = Console.ReadLine();
                                continue;
                            }
                            else
                            {
                                balance -= 15.99;
                                total += 15.99;
                                Console.WriteLine($"Bought {input}");

                            }
                            break;
                        case "Zplinter Zell":
                            if (balance < 19.99)
                            {
                                Console.WriteLine("Too Expensive");
                                input = Console.ReadLine();
                                continue;
                            }
                            else
                            {
                                balance -= 19.99;
                                total += 19.99;
                                Console.WriteLine($"Bought {input}");

                            }
                            break;
                        case "Honored 2":
                            if (balance < 59.99)
                            {
                                Console.WriteLine("Too Expensive");
                                input = Console.ReadLine();
                                continue;
                            }
                            else
                            {
                                balance -= 59.99;
                                total += 59.99;
                                Console.WriteLine($"Bought {input}");

                            }
                            break;
                        case "RoverWatch":
                            if (balance < 29.99)
                            {
                                Console.WriteLine("Too Expensive");
                                input = Console.ReadLine();
                                continue;
                            }
                            else
                            {
                                balance -= 29.99;
                                total += 29.99;
                                Console.WriteLine($"Bought {input}");

                            }
                            break;
                        case "RoverWatch Origins Edition":
                            if (balance < 39.99)
                            {
                                Console.WriteLine("Too Expensive");
                                input = Console.ReadLine();
                                continue;
                            }
                            else
                            {
                                balance -= 39.99;
                                total += 39.99;
                                Console.WriteLine($"Bought {input}");

                            }
                            break;

                    }

                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        isOutOfMoney = true;
                        break;
                    }
                }
                input = Console.ReadLine();
            }

            if (!isOutOfMoney)
            {
                Console.WriteLine($"Total spent: ${total:F2}. Remaining: ${balance:F2}");
            }
        }
    }
}
