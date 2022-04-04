using System;
using System.Collections.Generic;

class Product
{
    public Product(decimal price, int quantity)
    {
        this.Price = price;
        this.Quantity = quantity;
    }

    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
namespace _4.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string command;

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] productArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string productName = productArgs[0];
                decimal price = decimal.Parse(productArgs[1]);
                int quantity = int.Parse(productArgs[2]);


                if (!products.ContainsKey(productName))
                {
                    Product newProduct = new Product(price, 0);
                    products[productName] = newProduct;
                }

                products[productName].Quantity += quantity;
                products[productName].Price = price;
            }

            PrintProducts(products);
        }

        static void PrintProducts(Dictionary<string, Product> products)
        {
            foreach (var kvp in products)
            {
                decimal totalPrice = kvp.Value.Price * kvp.Value.Quantity;

                Console.WriteLine($"{kvp.Key} -> {totalPrice:F2}");
            }
        }
    }
}
