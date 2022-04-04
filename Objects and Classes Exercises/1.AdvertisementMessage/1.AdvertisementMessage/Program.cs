using System;
using System.Text;

namespace _1.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = {"Exellent product",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exeptional product",
                "I can't live without this product."};

            string[] events = { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"};

            string[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            string[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            int numberOfMessages = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMessages; i++)
            {
                StringBuilder sb = new StringBuilder();
                Random random = new Random();

                string currentPhrase = phrases[random.Next(0, phrases.Length)];
                sb.Append($"{currentPhrase} ");
                string currentEvent = events[random.Next(0, events.Length)];
                sb.Append($"{currentEvent} ");
                string currentAuthor = authors[random.Next(0, authors.Length)];
                sb.Append($"{currentAuthor}  - ");
                string currentCity = cities[random.Next(0, cities.Length)];
                sb.Append($"{currentCity}.");

                Console.WriteLine(sb);

            }


        }
    }
}
