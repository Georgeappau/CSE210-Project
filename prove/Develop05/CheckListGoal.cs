public class ChecklistGoal : Goal
{
    private int _desiredCompletions;
    private int _desiredBonusPoints;
    private int _progress;
    public ChecklistGoal(string _goalName, string _goalDescription, int progress, int desiredCompletions, int desiredBonus, bool _completed, int _goalValueInPoints, int _earnedPoints) : base(_goalName, _goalDescription, _goalValueInPoints, _completed, _earnedPoints)
    {
        _desiredCompletions = desiredCompletions;
        _desiredBonusPoints = desiredBonus;
        _progress = progress;
    }
    public void SetProgress()
    {
        _progress++;
    }
    public int GetProgress()
    {
        return _progress;
    }
    public void SetDesiredCompletions(int desired)
    {
        _desiredCompletions = desired;
    }
    public int GetDesiredCompletions()
    {
        return _desiredCompletions;
    }
    public void SetBonus(int desired)
    {
        _desiredBonusPoints = desired;
    }
    public int GetBonus()
    {
        return _desiredBonusPoints;
    }
    public ChecklistGoal()
    {
    }
    public override void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        SetGoalName(Console.ReadLine());
        Console.WriteLine("What is the description of this goal?");
        SetDescription(Console.ReadLine());
        Console.WriteLine("How many points do you want to set for this goal? ");
        SetDesiredPoints(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        SetDesiredCompletions(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("What is the bonus for completing it many times?");
        SetBonus(Convert.ToInt32(Console.ReadLine()));
    }
    public override void RecordEvent()
    {
        SetProgress();
        SetEarnedPoints(GetDesiredPoints());

        if (GetProgress() == GetDesiredCompletions())
        {
            SetCompleted(true);
            SetEarnedPoints(GetBonus());
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