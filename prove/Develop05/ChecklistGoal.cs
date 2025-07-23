public class ChecklistGoal : Goal
{
    public override void UserCreate()
    {
        _type = "ChecklistGoal";
        _progress = 0;
        Console.Write("What is the name of your goal? ");
        _title = Console.ReadLine();
        Console.Write($"What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write($"What is the amount of points associated with this goal? ");
        _incrementalPoints = int.Parse(Console.ReadLine());
        Console.Write($"How many times does this goal need to be accomplished for a bonus? ");
        _steps = int.Parse(Console.ReadLine());
        Console.Write($"What is the bonus for accomplishing it that many times? ");
        _finalPoints = int.Parse(Console.ReadLine());

    }

    public override void Record()
    {
        _progress++;
        if (_progress == _steps)
        {
            Console.WriteLine($"Congratulations! You have earned {_finalPoints + _incrementalPoints} points!");
            MarkComplete();
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_incrementalPoints} points!");
        }
    }
}