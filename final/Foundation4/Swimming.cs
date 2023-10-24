using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000; // kilometers
    }

    public override double GetSpeed()
    {
        return 60 * (GetDistance() / _minutes); // kilometers per hour
    }

    public override double GetPace()
    {
        return _minutes / GetDistance(); // minutes per kilometer
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min/km";
    }
}