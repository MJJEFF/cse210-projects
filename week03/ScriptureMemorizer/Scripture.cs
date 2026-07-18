using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
    }

    public string GetDisplayText()
    {
        return "";
    }

    public void HideRandomWords()
    {
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}