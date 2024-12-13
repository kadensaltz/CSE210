using System;

class Receptions : Event
{
    private string _email;

    public Receptions(string title, string description, string date, string time, Address address, string email)
        : base(title, description, date, time, address)
    {
        _email = email;
    }

    protected override string GetEventType()
    {
        return "Reception";
    }

    public override string FullDetails()
    {
        return $"{base.StandardDetails()}\nRSVP Email: {_email}";
    }
}