class Lecture : Event
{
    private string _speakerName;
    int _capacity;

    public Lecture() : base()
    {
        _speakerName = "";
        _capacity = 0;
    }
    public Lecture(string speakerName, int capacity, string eventTitle, string description, string date, string time, Address address, string eventType) : base(eventTitle, description, date, time, address, eventType)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
    public override string FullDetail()
    {
        return base.FullDetail() + $"Speaker: {_speakerName}, Capacity {_capacity}";
    }
}