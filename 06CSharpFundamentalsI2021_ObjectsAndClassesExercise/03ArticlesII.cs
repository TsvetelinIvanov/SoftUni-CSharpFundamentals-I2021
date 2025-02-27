using System;
using System.Linq;
using System.Collections.Generic;

namespace _03ArticlesII
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; private set; }

        public string Content { get; private set; }

        public string Author { get; private set; }

        public void Rename(string title)
        {
            this.Title = title;
        }

        public void Edit(string content)
        {
            this.Content = content;
        }

        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }

        public override string ToString()
        {
            return this.Title + " - " + this.Content + ": " + this.Author;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int articlesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < articlesCount; i++)
            {
                string[] articleData = Console.ReadLine().Split(", ");
                string title = articleData[0];
                string content = articleData[1];
                string author = articleData[2];
                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            string criteria = Console.ReadLine();
            switch (criteria)
            {
                case "title":
                    articles.OrderBy(a => a.Title).ToList().ForEach(a => Console.WriteLine(a));
                    break;
                case "content":
                    articles.OrderBy(a => a.Content).ToList().ForEach(a => Console.WriteLine(a));
                    break;
                case "author":
                    articles.OrderBy(a => a.Author).ToList().ForEach(a => Console.WriteLine(a));
                    break;
            }            
        }
    }
}
