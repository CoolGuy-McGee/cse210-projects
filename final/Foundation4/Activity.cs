public abstract class Activity
{
    private string _name;
    private DateOnly _date;
    private int _duration;

    public Activity(DateOnly date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public DateOnly GetDate()
    {
        return _date;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public double DoubleCleanUp(double number)
    {
        return Math.Round(number, 2, MidpointRounding.AwayFromZero);
    }

    public abstract double CalcDistance();
    public abstract double CalcSpeed();
    public abstract double CalcPace();

    public void GetSummary()
    {
        Console.WriteLine($"{GetDate()} {GetName()} ({GetDuration()} min): Distance {CalcDistance()} miles, Speed {CalcSpeed()} mph, Pace: {CalcPace()} min per mile");
    }
}