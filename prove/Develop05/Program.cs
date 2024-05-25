using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("0. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddGoal(manager);
                    break;
                case 2:
                    RecordEvent(manager);
                    break;
                case 3:
                    manager.DisplayGoals();
                    break;
                case 4:
                    manager.DisplayScore();
                    break;
                case 5:
                    Console.WriteLine("Enter filename:");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    break;
                case 6:
                    Console.WriteLine("Enter filename:");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static void AddGoal(GoalManager manager)
    {
        Console.WriteLine("Enter goal type (Simple, Eternal, Checklist):");
        string type = Console.ReadLine();

        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal points:");
        int points = int.Parse(Console.ReadLine());

        switch (type.ToLower())
        {
            case "simple":
                manager.AddGoal(new SimpleGoal(name, points));
                break;
            case "eternal":
                manager.AddGoal(new EternalGoal(name, points));
                break;
            case "checklist":
                Console.WriteLine("Enter target count:");
                int targetCount = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter bonus points:");
                int bonusPoints = int.Parse(Console.ReadLine());

                manager.AddGoal(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type");
                break;
        }
    }

    static void RecordEvent(GoalManager manager)
    {
        Console.WriteLine("Enter goal name to record event:");
        string name = Console.ReadLine();

        manager.RecordEvent(name);
    }
}
