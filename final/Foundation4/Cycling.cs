using System;

class Cycling : Activity
{
    private int _speed;

    public Cycling(DateTime date, float time, int speed) : base(date, time)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return (_speed * _time) / 60;
    }

    public override float GetSpeed()
    {
        return _speed;
    }
}