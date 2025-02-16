using System;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word()
    {
        _word = "";
        _isHidden = false;
    }

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void Hide()
    {
        if (!_isHidden)
        {
            _word = new string('-', _word.Length);
            _isHidden = true;
        }
    }

    public string GetWord()
    {
        return _word;
    }

    public bool GetHidden()
    {
        return _isHidden;
    }
}