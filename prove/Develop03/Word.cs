using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Word
{
    private List<string> _verse;
    private List<int> _usedIndexes;
    private int _maxIndexes;
    private bool _isFirstProcess;

    public Word(string verse, int maxIndexes)
    {
        _verse = new List<string>(verse.Split(' '));
        _usedIndexes = new List<int>();
        _maxIndexes = maxIndexes;
        _isFirstProcess = true;
    }

    public string ProcessVerse()
    {
        if (!_isFirstProcess)
        {
            HideWords();
        }
        else
        {
            _isFirstProcess = false;
        }

        return string.Join(" ", _verse);
    }

    private void HideWords()
    {
        Random random = new Random();
        int wordsToHide = Math.Min(3, _verse.Count - _usedIndexes.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index;
            do
            {
                index = random.Next(_verse.Count);
            } while (_usedIndexes.Contains(index));

            _usedIndexes.Add(index);
            _verse[index] = new string('_', _verse[index].Length);
        }
    }

    public bool Status()
    {
        return _usedIndexes.Count >= _maxIndexes;
    }

    public List<int> GetUsedIndexes()
    {
        return _usedIndexes;
    }
}
