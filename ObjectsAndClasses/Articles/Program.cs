namespace Articles
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var articleArgsInput = Console.ReadLine().Split(", ").ToArray();
            var articleTitle = articleArgsInput[0];
            var articleContent = articleArgsInput[1];
            var articleAuthor = articleArgsInput[2];

            var article = new Article(articleTitle, articleContent, articleAuthor);

            var modifyingArticleOperationsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < modifyingArticleOperationsCount; i++)
            {
                var currentOperation = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var curCommand = currentOperation[0];
                var articleElementNewValue = currentOperation[1];

                switch (curCommand)
                {
                    case "Edit":
                        article.Edit(articleElementNewValue);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(articleElementNewValue);
                        break;
                    case "Rename":
                        article.Rename(articleElementNewValue);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }
}
