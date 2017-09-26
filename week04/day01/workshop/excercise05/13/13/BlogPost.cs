using System;

namespace _13
{
    public class BlogPost
    {
        public string AuthorName;
        private string Title;
        private string Text;
        private DateTime PublicationDate;

        public BlogPost(string AuthorName, string Title, string Text, DateTime PublicationDate)
        {
            Console.WriteLine("\"" + Title + "\" titled by " + AuthorName + " posted at \"" + PublicationDate + "\"\n\t" + Text);
        }
    }

}