using System;

namespace _03.Articles2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            List<Article> articleList = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                Article article = new Article(input[0], input[1], input[2]);
                articleList.Add(article);
            }

            foreach (Article article in articleList)
            {
                article.ToString();
            }
        }

        class Article
        {
            public Article() { }

            public Article(string title, string content, string author) 
            {
                Title = title;
                Content = content;
                Author = author;
            }


            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public void ToString()
            {
                Console.WriteLine($"{Title} - {Content}: {Author}");
            }

            public void Empty() {}
        }
    }
}
