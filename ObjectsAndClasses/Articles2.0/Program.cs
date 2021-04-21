namespace Articles2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            var articleInputsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < articleInputsCount; i++)
            {
                var curArticleArgs = Console.ReadLine().Split(", ").ToArray();
                var articleTitle = curArticleArgs[0];
                var articleContent = curArticleArgs[1];
                var articleAuthor = curArticleArgs[2];

                var curArticle = new Article(articleTitle, articleContent, articleAuthor);
                articles.Add(curArticle);
            }

            var sortCryteria = Console.ReadLine();

            if (sortCryteria == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }
            else if (sortCryteria == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            else if (sortCryteria == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }

            Console.WriteLine(String.Join(Environment.NewLine, articles));
        }
    }
}
