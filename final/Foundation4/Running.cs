using System;

class Running : Activity
{
    private int _distance;

    public Running(DateTime date, float time, int distance) : base(date, time)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }
}