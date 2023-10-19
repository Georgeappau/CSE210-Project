public class ChecklistGoal : Goal
{
    private int _completeTimes;
    private int _bonusPoints;
    private int _numCompleted;
    public ChecklistGoal(string _goalName, string _goalDescription, int numCompleted, int completeTimes, int bonusPoints, bool _isCompleted, int _goalPoints, int _completedPoints) : base(_goalName, _goalDescription, _goalPoints, _isCompleted, _completedPoints)
    {
        _completeTimes = completeTimes;
        _bonusPoints = bonusPoints;
        _numCompleted = numCompleted;
    }
    public void SetNumCompleted()
    {
        _numCompleted++;
    }
    public int GetNumCompleted()
    {
        return _numCompleted;
    }
    public void SetCompleteTimes(int num)
    {
        _completeTimes = num;
    }
    public int GetCompleteTimes()
    {
        return _completeTimes;
    }
    public void SetBonus(int num)
    {
        _bonusPoints = num;
    }
    public int GetBonus()
    {
        return _bonusPoints;
    }
    public ChecklistGoal()
    {
    }
    public override void CreateGoal()
    {
        Console.WriteLine("What is your checklist goal? ");
        SetGoalName(Console.ReadLine());
        Console.WriteLine("Please add a description to your goal: ");
        SetDescription(Console.ReadLine());
        Console.WriteLine("Please set points for your goal: ");
        SetPoints(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Please add number of times this goal must be completed to earn bonus: ");
        SetCompleteTimes(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Please set the bomus points: ");
        SetBonus(Convert.ToInt32(Console.ReadLine()));
    }
    public override void RecordEvent()
    {
        SetNumCompleted();
        SetCompletedPoints(GetPoints());

        if (GetNumCompleted() == GetCompleteTimes())
        {
            SetCompleted(true);
            SetCompletedPoints(GetBonus());
        }

    }

    public override string PrintIsComplete()
    {
        if (GetCompleted())
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }

}