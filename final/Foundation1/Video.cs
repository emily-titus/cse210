using System;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments;

    public Video()
    {
        _title = "";
        _author = "";
        _lengthSeconds = 0;
        _comments = new List<Comment>();
    }
    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _lengthSeconds = length;
        _comments = comments;
    }

    public int NumOfComments()
    {
        return _comments.Count;
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _lengthSeconds;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
}