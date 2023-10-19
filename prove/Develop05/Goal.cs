public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private bool _isCompleted = false;
    private int _completedPoints;

    //Default constructor
    public Goal(){}
    public Goal(string goalName, string goalDescription, int goalPoints, bool isCompleted, int completedPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _isCompleted = isCompleted;
        _completedPoints = completedPoints;
    }

    public Goal(string goalName, string goalDescription, bool isCompleted)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _isCompleted = isCompleted;
    }
    
    public string GetGoalName()
    {
        return _goalName;
    }

    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }


    public string GetDescription()
    {
        return _goalDescription;
    }

    public void SetDescription(string description)
    {
        _goalDescription = description;
    }

    public int GetPoints()
    {
        return _goalPoints;
    }

    public void SetPoints(int _points)
    {
        _goalPoints = _points;
    }


    public void SetCompleted(bool completed)
    {
        _isCompleted = completed;
    }
    public bool GetCompleted()
    {
        return _isCompleted;
    }



    public void SetCompletedPoints(int points)
    {
        _completedPoints = _completedPoints + points;
    }
    public int GetCompletedPoints()
    {
        return _completedPoints;
    }

    public abstract void CreateGoal();
    public abstract void RecordEvent();
    public abstract string PrintIsComplete();

}