class Bicycle : Activity
{
    private double _speedMph;

    public Bicycle() : base()
    {
        _speedMph = 0;
    }
    public Bicycle(double speedMph, string date, int lengthMinutes, string name) : base(date, lengthMinutes, name)
    {
        _speedMph = speedMph;
    }
    public override double GetDistance()
    {
        return (_speedMph * _lengthMinutes) / 60;
    }
    public override double GetSpeed()
    {
        return _speedMph;
    }
    public override double GetPace()
    {
        return 60 / _speedMph;
    }
}