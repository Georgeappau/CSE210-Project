using System;

public class Video
{
    public string _title; 
    public string _author; 
    public int _lengthInSeconds; 
    public List<Comment> _comments; 

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string text)
    {
        Comment newComment = new Comment(commenterName, text);
        _comments.Add(newComment);
    }

    public int GetNumComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment._commenterName}: {comment._text}");
        }
        Console.WriteLine();
    }
}