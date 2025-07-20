public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateOnly date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
        SetName("Cycling");
    }

    public override double CalcDistance()
    {
        double distance = (CalcSpeed() / 60) * GetDuration();
        return DoubleCleanUp(distance);
    }

    public override double CalcSpeed()
    {
        return DoubleCleanUp(_speed);
    }

    public override double CalcPace()
    {
        double pace = 60 / CalcSpeed();
        return DoubleCleanUp(pace);
    }
}