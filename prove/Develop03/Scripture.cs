public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void Memorize()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, _words.Count + 1);

        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = random.Next(0, _words.Count);
            _words[randomIndex].Hide();
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"Scripture: {_reference.GetDisplayText()}");
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetDisplayText()} ");
        }
        Console.WriteLine();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

    public string GetReferenceDisplayText()
    {
        return _reference.GetDisplayText();
    }
}
