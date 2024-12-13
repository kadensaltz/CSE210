using System;
using System.Diagnostics;

class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, float time, int laps) : base(date, time)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return  (_laps * 50 / 1000f) * 0.62f;
    }
}