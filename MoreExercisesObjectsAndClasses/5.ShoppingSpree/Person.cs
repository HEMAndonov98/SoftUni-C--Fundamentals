using System.Collections.Generic;

namespace _5.ShoppingSpree
{
    public class Person
    {
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.BagOfProducts = new List<string>();
        }

        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<string> BagOfProducts { get; set; }
    }
}
