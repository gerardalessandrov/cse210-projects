using System;
using System.Collections.Generic;


public class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}


public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthSeconds { get; set; }
    private List<Comment> comments;

    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
        comments = new List<Comment>();
    }


    public void AddComment(string commenterName, string text)
    {
        comments.Add(new Comment(commenterName, text));
    }


    public int GetNumberOfComments()
    {
        return comments.Count;
    }


    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");

        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
        }

        Console.WriteLine();
    }
}

