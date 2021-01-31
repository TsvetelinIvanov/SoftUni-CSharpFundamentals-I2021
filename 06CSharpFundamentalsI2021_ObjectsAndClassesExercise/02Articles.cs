using System;

namespace _02Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleData = Console.ReadLine().Split(", ");
            string title = articleData[0];
            string content = articleData[1];
            string author = articleData[2];
            Article article = new Article(title, content, author);
            int commandsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsCount; i++)
            {
                string[] commandLine = Console.ReadLine().Split(": ");
                string command = commandLine[0];
                switch (command)
                {
                    case "Rename":
                        string newTitle = commandLine[1];
                        article.Rename(newTitle);
                        break;
                    case "Edit":
                        string newContent = commandLine[1];
                        article.Edit(newContent);
                        break;
                    case "ChangeAuthor":
                        string newAuthor = commandLine[1];
                        article.ChangeAuthor(newAuthor);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }

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
}
