public class GoalManager : Goal
{
    private List<Goal> _goals = new List<Goal>();
    private int _points;

    public void AddGoal(Goal goal)
    {
        if (!_goals.Contains(goal))
        {
            _goals.Add(goal);
        }
    }

    public void AddPoints(int points)
    {
        _points = _points + points;
    }


    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        int listNum = 0;
        foreach (var goal in _goals)
        {
            listNum++;
            bool complete = goal.GetComplete();
            string completed = " ";
            if (complete)
            {
                completed = "X";
            }
            string checkListAppend = "";
            if (goal.GetGoalType() == "ChecklistGoal")
            {
                checkListAppend = $"-- Currently completed: {goal.GetProgress()}/{goal.GetSteps()}";
            }
            Console.WriteLine($"{listNum}.  [{completed}] {goal.GetTitle()} ({goal.GetDesc()}) {checkListAppend}");
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, false))
        {
            foreach (var goal in _goals)
            {
                string type = goal.GetGoalType();
                string title = goal.GetTitle();
                string description = goal.GetDesc();
                int incrementalPoints = goal.GetIncPoints();
                int finalPoints = goal.GetFinPoints();
                int steps = goal.GetSteps();
                int progress = goal.GetProgress();
                bool isComplete = goal.GetComplete();
                outputFile.WriteLine($"{type}^{title}^{description}^{incrementalPoints}^{finalPoints}^{steps}^{progress}^{isComplete}");
            }
        }
    }

    public void Load(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        _points = 0;
        _goals.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split("^");

            string type = parts[0];
            string title = parts[1];
            string description = parts[2];
            int incrementalPoints = int.Parse(parts[3]);
            int finalPoints = int.Parse(parts[4]);
            int steps = int.Parse(parts[5]);
            int progress = int.Parse(parts[6]);
            bool isComplete = bool.Parse(parts[7]);
            if (type == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal();
                simpleGoal.Create(type, title, description, incrementalPoints, finalPoints, steps, progress, isComplete);
                AddGoal(simpleGoal);
                LoadPoints(simpleGoal);
            }
            else if (type == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal();
                eternalGoal.Create(type, title, description, incrementalPoints, finalPoints, steps, progress, isComplete);
                AddGoal(eternalGoal);
                LoadPoints(eternalGoal);
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal();
                checklistGoal.Create(type, title, description, incrementalPoints, finalPoints, steps, progress, isComplete);
                AddGoal(checklistGoal);
                LoadPoints(checklistGoal);
            }
        }
    }

    public void AddPoints(Goal goal)
    {
        string type = goal.GetGoalType();
        bool isComplete = goal.GetComplete();
        int finalPoints = goal.GetFinPoints();
        int incrementalPoints = goal.GetIncPoints();
        int steps = goal.GetSteps();
        int addedPoints = 0;
        if (type == "SimpleGoal")
        {
            if (isComplete)
            {
                addedPoints = _points + finalPoints;
            }
        }
        else if (type == "EternalGoal")
        {
            addedPoints = _points + incrementalPoints;
        }
        else if (type == "ChecklistGoal")
        {
            if (isComplete)
            {
                addedPoints = _points + (incrementalPoints * steps) + finalPoints;
            }
            else
            {
                addedPoints = _points + incrementalPoints;
            }
        }
        _points = addedPoints;
        Console.WriteLine($"You now have {_points} points.");
    }

    public void LoadPoints(Goal goal)
    {
        string type = goal.GetGoalType();
        bool isComplete = goal.GetComplete();
        int finalPoints = goal.GetFinPoints();
        int incrementalPoints = goal.GetIncPoints();
        int progress = goal.GetProgress();
        int steps = goal.GetSteps();
        if (type == "SimpleGoal")
        {
            if (isComplete)
            {
                _points = _points + finalPoints;
            }
        }
        else if (type == "EternalGoal")
        {
            _points = _points + (incrementalPoints * progress);
        }
        else if (type == "ChecklistGoal")
        {
            if (isComplete)
            {
                _points = _points + (incrementalPoints * steps) + finalPoints;
            }
        }
    }

    public override void UserCreate()
    {
        throw new NotImplementedException();
    }
    public override void Record()
    {
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        int index = choice - 1;
        _goals[index].Record();
        AddPoints(_goals[index]);
    }

    public void Menu()
    {
        int choice = 2;
        while (choice != 6)
        {
            Console.WriteLine($"\nYou have {_points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create new goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Save goals");
            Console.WriteLine("  4. Load goals");
            Console.WriteLine("  5. Record event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.UserCreate();
                    AddGoal(simpleGoal);
                }
                if (choice == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.UserCreate();
                    AddGoal(eternalGoal);
                }
                if (choice == 3)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.UserCreate();
                    AddGoal(checklistGoal);
                }
                choice = 2;
            }
            if (choice == 2)
            {
                ListGoals();
            }
            if (choice == 3)
            {
                Console.Write("What is the filename for this goal file? ");
                string filename = Console.ReadLine();
                Save(filename);
            }
            if (choice == 4)
            {
                Console.Write("What is the filename for this goal file? ");
                string filename = Console.ReadLine();
                Load(filename);
            }
            if (choice == 5)
            {
                Record();
            }
            if (choice == 6)
            {

            }
            else
            {
                choice = 2;
            }
        }
    }
}