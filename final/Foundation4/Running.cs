using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return 60 * (_distance / _minutes) ; // miles per hour
    }

    public override double GetPace()
    {
        return _minutes / _distance; // minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {_distance:F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }
}