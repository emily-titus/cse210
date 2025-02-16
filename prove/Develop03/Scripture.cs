using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture()
    {
        _reference = new Reference();
        _words = new List<Word>();
    }

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public string GetFormat()
    {
        string display = _reference.GetFormat();
        display += "\n";
        foreach (Word word in _words)
        {
            display += " ";
            display += word.GetWord();
        }
        return display;
    }
    public List<Word> GetWords()
    {
        return _words;
    }
}