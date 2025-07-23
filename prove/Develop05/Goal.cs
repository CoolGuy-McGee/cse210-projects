using System.IO;

public abstract class Goal
{
    protected string _type;
    protected string _title;
    protected string _description;
    protected int _incrementalPoints;
    protected int _finalPoints;
    protected int _steps;
    protected int _progress;
    protected bool _isComplete = false;

    //public Goal(string type, string title, string description, int incrementalPoints, int finalPoints, int steps, int progress)
    //{
    //    _type = type;
    //    _title = title;
    //    _description = description;
    //    _incrementalPoints = incrementalPoints;
    //    _finalPoints = finalPoints;
    //    _steps = steps;
    //    _progress = progress;
    //}

    public void MarkComplete()
    {
        _isComplete = true;
    }
    public string GetGoalType()
    {
        return _type;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDesc()
    {
        return _description;
    }

    public int GetIncPoints()
    {
        return _incrementalPoints;
    }

    public int GetFinPoints()
    {
        return _finalPoints;
    }

    public int GetSteps()
    {
        return _steps;
    }

    public int GetProgress()
    {
        return _progress;
    }

    public bool GetComplete()
    {
        return _isComplete;
    }

    public void Create(string type, string title, string description, int incrementalPoints, int finalPoints, int steps, int progress, bool isComplete)
    {
        _type = type;
        _title = title;
        _description = description;
        _incrementalPoints = incrementalPoints;
        _finalPoints = finalPoints;
        _steps = steps;
        _progress = progress;
        _isComplete = isComplete;
    }

    public abstract void UserCreate();
    public abstract void Record();
}