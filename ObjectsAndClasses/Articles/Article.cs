namespace Articles
{
    public class Article
    {
        private string title;
        private string content;
        private string author;
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title
        {
            get => this.title;

            set
            {
                this.title = value;
            }
        }
        public string Content
        {
            get => this.content;

            set
            {
                this.content = value;
            }
        }
        public string Author
        {
            get => this.author;

            set
            {
                this.author = value;
            }
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            var result = $"{this.Title} - {this.Content}: {this.Author}";

            return result;
        }
    }
}
