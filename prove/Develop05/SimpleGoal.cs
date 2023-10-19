public class SimpleGoal : Goal
{
    //Default contructor
    public SimpleGoal(){}
    public SimpleGoal(string _goalName, string _goalDescription, int _goalPoints, bool _isCompleted, int _completedPoints) : base(_goalName, _goalDescription, _goalPoints, _isCompleted, _completedPoints){}

    public override void CreateGoal()
    {
        Console.WriteLine("What is your simple goal? ");
        SetGoalName(Console.ReadLine());
        Console.WriteLine("Please add a description to this goal: ");
        SetDescription(Console.ReadLine());
        Console.WriteLine("Please set points for this goal: ");
        SetPoints(Convert.ToInt32(Console.ReadLine()));
    }

    public override void RecordEvent()
    {
        SetCompleted(true);
        SetCompletedPoints(GetPoints());

    }
    
    //Show completed goals
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