using System;

public class Scripture
{
    private string _reference;
    private string _hiddenVerse;
    private Word _words;
    private bool _isFirstDisplay;

    public Scripture()
    {
        _words = new Word("", 0);
        _isFirstDisplay = true;
    }

    public void GetReference()
    {
        Reference reference = new Reference();
        _reference = reference.GetRef();
        _hiddenVerse = reference.GetVerse();
        _words = new Word(_hiddenVerse, _hiddenVerse.Split(' ').Length);
    }

    public void Display()
    {
        if (!_isFirstDisplay)
        {
            Console.Clear();
        }
        else
        {
            _isFirstDisplay = false;
        }

        Console.WriteLine("Scripture Mastery");
        Console.WriteLine(_reference);
        string processedVerse = _words.ProcessVerse();
        Console.WriteLine(processedVerse);
    }

    public bool Status()
    {
        return _words.Status();
    }
}
