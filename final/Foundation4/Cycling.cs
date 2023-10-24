using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed; // miles per hour
    }

    public override double GetPace()
    {
        return 60.0 / _speed; // minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {_speed:F2} mph, Pace: {GetPace():F2} min/mile";
    }
}