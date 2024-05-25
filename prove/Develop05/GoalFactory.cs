public static class GoalFactory
{
    public static Goal CreateGoal(string type, string details)
    {
        string[] parts = details.Split(",");

        switch (type)
        {
            case "SimpleGoal":
                return new SimpleGoal(parts[0], int.Parse(parts[1]));
            case "EternalGoal":
                var eternalGoal = new EternalGoal(parts[0], int.Parse(parts[1]));
                eternalGoal.SetTimesRecorded(int.Parse(parts[2]));
                return eternalGoal;
            case "ChecklistGoal":
                var checklistGoal = new ChecklistGoal(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[4]));
                checklistGoal.SetCurrentCount(int.Parse(parts[3]));
                return checklistGoal;
            default:
                return null;
        }
    }
}
