public class EternalGoal : Goal
{
    public int TimesRecorded { get; private set; }

    public EternalGoal(string name, int points) : base(name, points)
    {
        TimesRecorded = 0;
    }

    public override void RecordEvent()
    {
        TimesRecorded++;
    }

    public override string GetProgress()
    {
        return $"Recorded {TimesRecorded} times";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name},{Points},{TimesRecorded}";
    }

    public void SetTimesRecorded(int timesRecorded)
    {
        TimesRecorded = timesRecorded;
    }
}
