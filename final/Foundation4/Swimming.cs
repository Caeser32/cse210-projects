public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int length, int laps)
        : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50) / 1000 * 0.62;
    public override double GetSpeed() => (GetDistance() / _length) * 60;
    public override double GetPace() => _length / GetDistance();
}
