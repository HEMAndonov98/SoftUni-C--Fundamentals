
namespace _5.ShoppingSpree
{
    public class Product
    {
        public Product(string productName, decimal productCost)
        {
            this.ProductName = productName;
            this.Cost = productCost;
        }

        public string ProductName { get; set; }
        public decimal Cost { get; set; }
    }
}
