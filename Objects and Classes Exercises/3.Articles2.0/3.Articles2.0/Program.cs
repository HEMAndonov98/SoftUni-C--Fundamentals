using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Articles2._0
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArcticles = int.Parse(Console.ReadLine());
            List<Article> articlesList = new List<Article>();

            for (int i = 0; i < numberOfArcticles; i++)
            {
                string[] articleArgs = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = articleArgs[0];
                string content = articleArgs[1];
                string author = articleArgs[2];

                Article newArticle = new Article(title, content, author);
                articlesList.Add(newArticle);
            }

            string orderByWhat = Console.ReadLine();

            switch (orderByWhat)
            {
                case"title":
                    articlesList.OrderBy(a => a.Title).ToList();
                    break;

                case "content":
                    articlesList.OrderBy(a => a.Content).ToList();
                    break;

                case "author":
                    articlesList.OrderBy(a => a.Author).ToList();
                    break;
            }

            Console.WriteLine(string.Join(Environment.NewLine, articlesList));
        }
    }
}
