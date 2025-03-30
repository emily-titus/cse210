using System;
class Comment
{
    private string _name;
    private string _textContent;

    public Comment()
    {
        _name = "";
        _textContent = "";
    }
    public Comment(string name, string textContent)
    {
        _name = name;
        _textContent = textContent;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetContent()
    {
        return _textContent;
    }
}