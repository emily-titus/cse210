class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;

    public Event()
    {
        _eventTitle = "";
        _description = "";
        _date = "";
        _time = "";
        _address = new Address();
        _eventType = "";
    }
    public Event(string eventTitle, string description, string date, string time, Address address, string eventType)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public string StandardDetail()
    {
        return $"{_eventTitle}:\n{_description}\n{_date} at {_time}\nAddress: {_address.FormatAddress()}";
    }
    public virtual string FullDetail()
    {
        return $"{_eventType} - {_eventTitle}:\n{_description}\n{_date} at {_time}\nAddress: {_address.FormatAddress()}\n";
    }
    public string ShortDescription()
    {
        return $"{_eventType} - {_eventTitle}\non {_date}";
    }
}