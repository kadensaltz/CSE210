using System;

class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    protected override string GetEventType()
    {
        return "Lecture";
    }

    public override string FullDetails()
    {
        return $"{base.StandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}