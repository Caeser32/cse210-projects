using System;

public class Activity
{
    protected DateTime _date;
    protected int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public DateTime GetDate() => _date;
    public int GetLength() => _length;

    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Activity ({_length} min): Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}
