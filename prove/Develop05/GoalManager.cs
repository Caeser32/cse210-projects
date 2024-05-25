using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals;
    private int totalScore;
    private int experiencePoints;
    private int level;

    public GoalManager()
    {
        goals = new List<Goal>();
        totalScore = 0;
        experiencePoints = 0;
        level = 1;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        var goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            totalScore += goal.Points;
            experiencePoints += goal.Points;
            CheckLevelUp();

            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete)
            {
                totalScore += checklistGoal.BonusPoints;
                experiencePoints += checklistGoal.BonusPoints;
                CheckLevelUp();
            }
        }
    }

    private void CheckLevelUp()
    {
        int requiredExperience = level * 1000;
        while (experiencePoints >= requiredExperience)
        {
            level++;
            experiencePoints -= requiredExperience;
            requiredExperience = level * 1000;
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.Name} - {goal.GetProgress()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {totalScore}");
        Console.WriteLine($"Experience Points: {experiencePoints}");
        Console.WriteLine($"Level: {level}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var goal in goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            outputFile.WriteLine($"Score:{totalScore}");
            outputFile.WriteLine($"Experience:{experiencePoints}");
            outputFile.WriteLine($"Level:{level}");
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                if (line.StartsWith("Score:"))
                {
                    totalScore = int.Parse(line.Split(":")[1]);
                }
                else if (line.StartsWith("Experience:"))
                {
                    experiencePoints = int.Parse(line.Split(":")[1]);
                }
                else if (line.StartsWith("Level:"))
                {
                    level = int.Parse(line.Split(":")[1]);
                }
                else
                {
                    string[] parts = line.Split(":");
                    string type = parts[0];
                    string details = parts[1];

                    Goal goal = GoalFactory.CreateGoal(type, details);
                    if (goal != null)
                    {
                        goals.Add(goal);
                    }
                }
            }
        }
    }
}
