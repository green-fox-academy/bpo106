using System;

public class BlogPost
{
    public string AuthorName;
    public string Title;
    public string Text;
    public DateTime PublicationDate;

    public BlogPost(string AuthorName, string Title, string Text, DateTime PublicationDate)
	{
        Console.WriteLine("\"" + Title + "\" titled by " + AuthorName + " posted at \"" + PublicationDate + "\"\n\t" + Text);
        Console.ReadLine();
	}
}
