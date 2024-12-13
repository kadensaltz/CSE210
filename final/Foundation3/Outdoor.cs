using System;

class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    protected override string GetEventType()
    {
        return "Outdoor";
    }

    public override string FullDetails()
    {
        return $"{base.StandardDetails()}\nWeather: {_weather}";
    }
}