using System;
using System.Collections.Generic;

public class Activity
{
    private DateTime date;
    public int durationMinutes;

    public Activity(DateTime date, int durationMinutes)
    {
        this.date = date;
        this.durationMinutes = durationMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{date.ToShortDateString()} - Duration: {durationMinutes} min";
    }
}


public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int durationMinutes, double distance)
        : base(date, durationMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (durationMinutes / 60.0);
    }

    public override double GetPace()
    {
        return durationMinutes / distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {distance:F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }
}

public class Cycling : Activity
{
    private double speed; // in km/h

    public Cycling(DateTime date, int durationMinutes, double speed)
        : base(date, durationMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * (durationMinutes / 60.0);
    }

    public override double GetPace()
    {
        return 60.0 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():F2} km, Speed: {speed:F2} kph, Pace: {GetPace():F2} min/km";
    }
}

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (durationMinutes / 60.0);
    }

    public override double GetPace()
    {
        return 60.0 / GetSpeed();
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min/km";
    }
};
