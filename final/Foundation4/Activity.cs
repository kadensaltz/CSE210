using System;
using System.IO.Pipes;

class Activity
{
    protected DateTime _date;
    protected float _time;

    public Activity(DateTime date, float time)
    {
        _date = date;
        _time = time;
    }

    public virtual float GetDistance()
    {
        return 0;
    }

    public virtual float GetSpeed()
    {
        return(GetDistance() / _time) * 60;
    }

    public virtual float GetPace()
    {
        return _time / GetDistance();
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} ({_time} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}