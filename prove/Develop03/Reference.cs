using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _lastVerse;

    public Reference()
    {

    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _lastVerse = lastVerse;
    }

    public string GetFormat()
    {
        string referenceFormat;

        if (_lastVerse == 0)
            referenceFormat = $"{_book} {_chapter}:{_verse}";
        else
            referenceFormat = $"{_book} {_chapter}:{_verse}-{_lastVerse}";


        return referenceFormat;
    }
}