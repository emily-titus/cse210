class Swimming : Activity
{
    private double _lap;

    public Swimming() : base()
    {
        _lap = 0;
    }
    public Swimming(double lap, string date, int lengthMinutes, string name) : base(date, lengthMinutes, name)
    {
        _lap = lap;
    }
    public override double GetDistance()
    {
        return _lap * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return GetDistance() / _lengthMinutes * 60;
    }
    public override double GetPace()
    {
        return _lengthMinutes / GetDistance();
    }
}