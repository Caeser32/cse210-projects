using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
    }

    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }

    public void DisplayAllScriptures()
    {
        for (int i = 0; i < _scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_scriptures[i].GetReferenceDisplayText()}");
        }
    }

    public Scripture GetScripture(int index)
    {
        if (index >= 0 && index < _scriptures.Count)
        {
            return _scriptures[index];
        }
        else
        {
            return null;
        }
    }
}
