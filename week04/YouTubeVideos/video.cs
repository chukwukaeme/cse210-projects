using System;
using System.Collections.Generic;

public class Video
{
    public string _Title { get; }
    public string _Author { get; }
    public int _Length { get; }
    private List<Comment> _Comments { get; }

    public Video(string title, string author, int length)
    {
        _Title = title;
        _Author = author;
        _Length = length;
        _Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _Comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"\nTitle: {_Title}");
        Console.WriteLine($"Author: {_Author}");
        Console.WriteLine($"Length: {_Length} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");

        foreach (var comment in _Comments)
        {
            comment.DisplayComment();
        }
    }
}
