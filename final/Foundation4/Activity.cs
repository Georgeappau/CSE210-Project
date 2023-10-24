using System;

public class Activity
{
    private DateTime _date;
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Default distance for the base class
    }

    public virtual double GetSpeed()
    {
        return 0; // Default speed for the base class
    }

    public virtual double GetPace()
    {
        return 0; // Default pace for the base class
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} ({GetType().Name}) - Duration: {_minutes} min";
    }
}