using System;
using System.Collections.Generic;

namespace _05HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string articleTitle = Console.ReadLine();
            string articleContent = Console.ReadLine();
            List<string> articleComments = new List<string>();
            string articleComment;
            while ((articleComment = Console.ReadLine()) != "end of comments")
            {
                articleComments.Add(articleComment);
            }

            Console.WriteLine($"<h1>{Environment.NewLine}    {articleTitle}{Environment.NewLine}</h1>");
            Console.WriteLine($"<article>{Environment.NewLine}    {articleContent}{Environment.NewLine}</article>");
            foreach (string comment in articleComments)
            {
                Console.WriteLine($"<div>{Environment.NewLine}    {comment}{Environment.NewLine}</div>");
            }
        }
    }
}