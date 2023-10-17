public class Utility
{
    public void WriteFile(List<Goal> goals)
    {
        Console.WriteLine("What is the file name you would like to choose? Enter .txt at the end");
        string _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(CalculateTotalPoints(goals));
            foreach (Goal goal in goals)
            {
                if (goal is ChecklistGoal)
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                    outputFile.WriteLine($"{goal.GetType()}:;{checklistGoal.GetGoalName()};{checklistGoal.GetDescription()};{checklistGoal.GetDesiredPoints()};{checklistGoal.GetBonus()}/{checklistGoal.GetProgress()};{checklistGoal.GetDesiredCompletions()};{checklistGoal.GetCompleted()};{checklistGoal.GetCompletedPoints()}");
                }
                else
                {
                    outputFile.WriteLine($"{goal.GetType()}:;{goal.GetGoalName()};{goal.GetDescription()};{goal.GetDesiredPoints()};{goal.GetCompleted()};{goal.GetCompletedPoints()}");

                }
            }
        }
    }

    public void LoadFile(List<Goal> goals)
    {
        Console.WriteLine("Please enter name of file to load?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split(";");
            string name = parts[1];
            string desc = parts[2];
            int desiredPoints = int.Parse(parts[3]);
            if (parts[4].Contains("/"))
            {
                string bonus = parts[4];
                string[] checklistParts = bonus.Split("/");
                bonus = checklistParts[0];
                int progress = int.Parse(checklistParts[1]);
                int bonusInt = int.Parse(bonus);
                int desired = int.Parse(checklistParts[1]);
                bool complete = bool.Parse(parts[6]);
                int earned = int.Parse(parts[7]);
                goals.Add(new ChecklistGoal(name, desc, progress, desired, bonusInt, complete, desiredPoints, earned));

            }
            else
            {
                int earned = int.Parse(parts[5]);
                bool complete = bool.Parse(parts[4]);
                string goalType = parts[0];
                if (goalType == "SimpleGoal:")
                {
                    goals.Add(new SimpleGoal(name, desc, desiredPoints, complete, earned));

                }
                else
                {
                    goals.Add(new EternalGoal(name, desc, desiredPoints, complete, earned));

                }
            }




        }

    }




    public int CalculateTotalPoints(List<Goal> goals)
    {
        int totalPoints = 0;
        foreach (Goal goal in goals)
        {
            totalPoints += goal.GetCompletedPoints();
        }
        return totalPoints;
    }
}
