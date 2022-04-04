using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.StoreBoxes
{
    class Item
    {
        public Item()
        {

        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box(int serialNumber,
            string itemName,
            decimal itemPrice,
            int itemQuantity)
        {
            Item = new Item();
            this.SerialNumber = serialNumber;
            this.Item.Name = itemName;
            this.Item.Price = itemPrice;
            this.ItemQuantity = itemQuantity;
        }

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PricePerBox
        {
            get
            {
                return ItemQuantity * Item.Price;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string rawInput;

            while ((rawInput = Console.ReadLine()) != "end")
            {
                string[] tokens = rawInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int serialNumber = int.Parse(tokens[0]);
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                Box newBox = new Box(serialNumber, itemName, itemPrice, itemQuantity);

                boxes.Add(newBox);

            }

            List<Box> orderedBoxesList = boxes.OrderByDescending(boxPrice => boxPrice.PricePerBox).ToList();


            foreach (Box box in orderedBoxesList)
            {
                Console.WriteLine($"{box.SerialNumber}{Environment.NewLine}" +
                    $" -- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}{Environment.NewLine}" +
                    $" -- ${box.PricePerBox:F2}");
            }
        }
    }
}
