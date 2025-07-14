public abstract class Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete = false;

    public abstract void BuildGoal();

    public void MarkComplete()
    {
        _isComplete = true;
    }
}