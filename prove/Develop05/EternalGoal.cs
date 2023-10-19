public class EternalGoal : Goal
{   
    //Default constructor
    public EternalGoal(){}
    public EternalGoal(string _goalName, string _goalDescription, int _goalPoints, bool _isCompleted, int _completedPoints) : base(_goalName, _goalDescription, _goalPoints, _isCompleted, _completedPoints){}
    public override void CreateGoal()
    {
        Console.WriteLine("What is your eternal goal? ");
        SetGoalName(Console.ReadLine());
        Console.WriteLine("Please add a description to your goal: ");
        SetDescription(Console.ReadLine());
        Console.WriteLine("Please set points for your goal: ");
        SetPoints(Convert.ToInt32(Console.ReadLine()));
    }
    public override void RecordEvent()
    {
        SetCompleted(true);
        SetCompletedPoints(GetPoints());

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