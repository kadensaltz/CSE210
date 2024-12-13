using System;

public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public string GetText()
    {
        return _text;
    }

    public string CompileComment()
    {
        return _name + ": " + _text;
    }
}