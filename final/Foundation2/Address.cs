class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {
        _street = "";
        _city = "";
        _state = "";
        _country = "";
    }
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUsa()
    {
        bool isInUsa = true;
        if (_country != "USA")
        {
            isInUsa = false;
        }
        return isInUsa;
    }
    public string FormatAddress()
    {
        string formatAddress = $"{_street}\n {_city},{_state}\n {_country} ";
        return formatAddress;
    }
}