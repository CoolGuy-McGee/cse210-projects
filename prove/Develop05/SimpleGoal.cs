public class SimpleGoal : Goal
{
    public override void UserCreate()
    {
        _type = "SimpleGoal";
        _steps = 1;
        _incrementalPoints = 0;
        _progress = 0;
        Console.Write("What is the name of your goal? ");
        _title = Console.ReadLine();
        Console.Write($"What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write($"What is the amount of points associated with this goal? ");
        _finalPoints = int.Parse(Console.ReadLine());

    }

    public override void Record()
    {
        Console.WriteLine($"Congratulations! You have earned {_finalPoints} points!");
        _progress = _steps;
        MarkComplete();
    }
}