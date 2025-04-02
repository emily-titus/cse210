class Outdoor : Event
{
    private string _weather;

    public Outdoor() : base()
    {
        _weather = "";
    }
    public Outdoor(string weather, string eventTitle, string description, string date, string time, Address address, string eventType) : base(eventTitle, description, date, time, address, eventType)
    {
        _weather = weather;
    }
    public override string FullDetail()
    {
        return base.FullDetail() + $"It's going to be {_weather}";
    }
}