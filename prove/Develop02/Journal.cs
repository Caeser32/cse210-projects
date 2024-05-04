
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> entries;
    private List<string> prompts;
    private string filename;

    public Journal()
    {
        entries = new List<JournalEntry>();
        prompts = new List<string>()
        {
            "What was the best part of your day?",
            "What did you learn today?",
            "How are you feeling right now?"
        };
        filename = "journal.txt";
    }

    public void WriteNewEntry()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine("Enter your response:");
        string response = Console.ReadLine();
        JournalEntry entry = new ConcreteJournalEntry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        };
        AddEntry(entry);
    }

    public void DisplayJournal()
    {
        foreach (JournalEntry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved to file.");
    }

    public void LoadFromFile()
    {
        entries.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    JournalEntry entry = new ConcreteJournalEntry
                    {
                        Date = parts[0],
                        Prompt = parts[1],
                        Response = parts[2]
                    };
                    entries.Add(entry);
                }
            }
        }
        Console.WriteLine("Journal loaded from file.");
    }

    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
        Console.WriteLine("New entry added to journal.");
    }
}
