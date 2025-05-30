using System;
using System.Collections.Generic;
public class Video
{
    public List<Comment> _comments = new List<Comment>();
    public string _title;
    public string _author;
    public double _length;

    public void CommentItems()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"-{comment}");
        }
    }

    public void AddComment(Comment myComment)
    {
        _comments.Add(myComment);
    }

    public int CountComment()
    {
        int count = _comments.Count;
        return count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length} minutes");
        Console.WriteLine($"{CountComment()} comment(s)");
        CommentItems();
        Console.WriteLine();
    }
}