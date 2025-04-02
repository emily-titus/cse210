class Reception : Event
{
    private string _emailRsvp;

    public Reception() : base()
    {
        _emailRsvp = "";
    }
    public Reception(string emailRsvp, string eventTitle, string description, string date, string time, Address address, string eventType) : base(eventTitle, description, date, time, address, eventType)
    {
        _emailRsvp = emailRsvp;
    }
    public override string FullDetail()
    {
        return base.FullDetail() + $"RSVP: {_emailRsvp}";
    }
}