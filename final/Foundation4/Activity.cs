class Activity
{
    private string _date;
    protected int _lengthMinutes;
    private string _name;

    public Activity()
    {
        _date = "";
        _lengthMinutes = 0;
        _name = "";
    }
    public Activity(string date, int lengthMinutes, string name)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
        _name = name;
    }

    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public string GetSummary()
    {
        return $"{_date} {_name} ({_lengthMinutes} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace().ToString("#.##")} min per mile";
    }
}