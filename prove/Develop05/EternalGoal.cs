public class EternalGoal : Goal
{
    public override void UserCreate()
    {
        _type = "EternalGoal";
        _steps = 0;
        _finalPoints = 0;
        _progress = 0;
        Console.Write("What is the name of your goal? ");
        _title = Console.ReadLine();
        Console.Write($"What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write($"What is the amount of points associated with this goal? ");
        _incrementalPoints = int.Parse(Console.ReadLine());

    }

    public override void Record()
    {
        Console.WriteLine($"Congratulations! You have earned {_incrementalPoints} points!");
        _progress++;
    }
}