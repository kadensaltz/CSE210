using System;

class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.DisplayAddress()}";
    }

    public string ShortDescription()
    {
        return $"Type: {GetEventType()}\nTitle: {_title}\nDate: {_date}";
    }

    protected virtual string GetEventType()
    {
        return "General Event";
    }

    public virtual string FullDetails()
    {
        return StandardDetails();
    }
}