public class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    public int CurrentCount { get; private set; }
    public int BonusPoints { get; private set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
        : base(name, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override void RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                IsComplete = true;
            }
        }
    }

    public override string GetProgress()
    {
        return $"Completed {CurrentCount}/{TargetCount} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Points},{TargetCount},{CurrentCount},{BonusPoints}";
    }


    public void SetCurrentCount(int currentCount)
    {
        CurrentCount = currentCount;
    }
}
