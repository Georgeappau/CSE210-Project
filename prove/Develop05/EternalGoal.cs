public class EternalGoal : Goal
{
    public EternalGoal()
    {
    }
    public EternalGoal(string _goalName, string _goalDescription, int _goalValueInPoints, bool _completed, int _earnedPoints) : base(_goalName, _goalDescription, _goalValueInPoints, _completed, _earnedPoints)
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
    }
    public override void RecordEvent()
    {
        SetCompleted(true);
        SetEarnedPoints(GetDesiredPoints());

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