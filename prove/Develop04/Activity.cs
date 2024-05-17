using System;
using System.Threading;

public abstract class Activity
{
    public int Duration { get; set; }
    public string ActivityName { get; set; }
    public string Description { get; set; }

    public void StartMessage()
    {
        Console.WriteLine($"Starting {ActivityName}");
        Console.WriteLine(Description);
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"You have completed {ActivityName} for {Duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds * 10; i++)
        {
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
    }

    public abstract void Run();
}
