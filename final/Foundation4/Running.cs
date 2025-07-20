public class Running : Activity
{
    private double _distance;

    public Running(DateOnly date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
        SetName("Running");
    }

    public override double CalcDistance()
    {
        return DoubleCleanUp(_distance);
    }

    public override double CalcSpeed()
    {
        double speed = (CalcDistance() / GetDuration()) * 60;
        return DoubleCleanUp(speed);
    }

    public override double CalcPace()
    {
        double pace = 60 / CalcSpeed();
        return DoubleCleanUp(pace);
    }
}