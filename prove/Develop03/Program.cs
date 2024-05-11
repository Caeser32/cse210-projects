using System;

class Program
{
    static void Main()
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Reference reference1 = new Reference("1 Nephi", 2, 15);
        Scripture scripture1 = new Scripture(reference1, "And my father dwelt in a tent.");
        library.AddScripture(scripture1);

        Reference reference2 = new Reference("Alma", 32, 21);
        Scripture scripture2 = new Scripture(reference2, "And now as I said concerning faith - faith is not to have a perfect knowledge of things.");
        library.AddScripture(scripture2);

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Add Scripture");
            Console.WriteLine("2. Display All Scriptures");
            Console.WriteLine("3. Memorize a Scripture");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddScripture(library);
                    break;
                case "2":
                    library.DisplayAllScriptures();
                    break;
                case "3":
                    MemorizeScripture(library);
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddScripture(ScriptureLibrary library)
    {
        Console.Write("Enter the book: ");
        string book = Console.ReadLine();
        Console.Write("Enter the chapter: ");
        int chapter = int.Parse(Console.ReadLine());
        Console.Write("Enter the start verse: ");
        int startVerse = int.Parse(Console.ReadLine());
        Console.Write("Enter the end verse (0 if single verse): ");
        int endVerse = int.Parse(Console.ReadLine());

        Console.Write("Enter the scripture text: ");
        string text = Console.ReadLine();

        if (endVerse == 0)
        {
            Reference reference = new Reference(book, chapter, startVerse);
            Scripture scripture = new Scripture(reference, text);
            library.AddScripture(scripture);
        }
        else
        {
            Reference reference = new Reference(book, chapter, startVerse, endVerse);
            Scripture scripture = new Scripture(reference, text);
            library.AddScripture(scripture);
        }
    }

    static void MemorizeScripture(ScriptureLibrary library)
    {
        Console.WriteLine("Choose a scripture to memorize:");
        library.DisplayAllScriptures();

        Console.Write("Enter the index of the scripture to memorize: ");
        int index = int.Parse(Console.ReadLine());

        Scripture selectedScripture = library.GetScripture(index - 1);

        if (selectedScripture != null)
        {
            while (!selectedScripture.IsCompletelyHidden())
            {
                selectedScripture.Display();
                Console.Write("Press Enter to hide more words or type 'quit' to exit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                selectedScripture.Memorize();
            }
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }
}
