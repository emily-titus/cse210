class Running : Activity
{
    private double _distance;

    public Running() : base()
    {
        _distance = 0;
    }
    public Running(double distance, string date, int lengthMinutes, string name) : base(date, lengthMinutes, name)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _lengthMinutes) * 60;
    }
    public override double GetPace()
    {
        return _lengthMinutes / _distance;
    }
}