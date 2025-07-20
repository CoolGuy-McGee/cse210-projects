public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateOnly date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
        SetName("Swimming");
    }

    public override double CalcDistance()
    {
        double laps = _laps;
        double distance = ((laps * 50) / 1000) * 0.62;
        return DoubleCleanUp(distance);
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