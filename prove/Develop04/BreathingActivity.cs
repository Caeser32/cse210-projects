using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        ActivityName = "Breathing Activity";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Run()
    {
        StartMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowEnhancedBreathingAnimation(3);
            Console.WriteLine("Breathe out...");
            ShowEnhancedBreathingAnimation(3);
        }

        EndMessage();
    }

    private void ShowEnhancedBreathingAnimation(int seconds)
    {
        int steps = 20;
        for (int i = 0; i < steps; i++)
        {
            Console.Write("\r" + new string(' ', i) + "O");
            Thread.Sleep(seconds * 50);
        }
        for (int i = steps; i > 0; i--)
        {
            Console.Write("\r" + new string(' ', i) + "O");
            Thread.Sleep(seconds * 50);
        }
    }
}
