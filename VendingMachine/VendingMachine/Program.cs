using System;

namespace cSharpExercices
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double money, change = 0;
            bool IsValid = double.TryParse(input, out money);
            bool isProduct = false;

            while (input != "Start")
            {
                if (IsValid && input == "2")
                {
                    change += 2;
                }
                else if (IsValid && input == "1")
                {
                    change += 1;
                }
                else if (IsValid && input == "0.5")
                {
                    change += 0.5;
                }
                else if (IsValid && input == "0.2")
                {
                    change += 0.2;
                }
                else if (IsValid && input == "0.1")
                {
                    change += 0.1;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }

                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Nuts" || input == "Water" || input == "Crisps" || input == "Soda" || input == "Coke")
                {
                    isProduct = true;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                if (isProduct)
                {
                    switch (input.ToLower())
                    {
                        case "nuts":
                            change -= 2.0;
                            if (change >= 0)
                            {
                                Console.WriteLine($"Purchased {input.ToLower()}");
                            }
                            else
                            {
                                change += 2.0;
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "water":
                            change -= 0.7;
                            if (change >= 0)
                            {
                                Console.WriteLine($"Purchased {input.ToLower()}");
                            }
                            else
                            {
                                change += 0.7;
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "crisps":
                            change -= 1.5;
                            if (change >= 0)
                            {
                                Console.WriteLine($"Purchased {input.ToLower()}");
                            }
                            else
                            {
                                change += 1.5;
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "soda":
                            change -= 0.8;
                            if (change >= 0)
                            {
                                Console.WriteLine($"Purchased {input.ToLower()}");
                            }
                            else
                            {
                                change += 0.8;
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "coke":
                            change -= 1.0;
                            if (change >= 0)
                            {
                                Console.WriteLine($"Purchased {input.ToLower()}");
                            }
                            else
                            {
                                change += 1.0;
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {change:F2}");
        }
    }
}
