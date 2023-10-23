public class Utility
{
    //Save user file
    public void SaveGoalFile(List<Goal> goals)
    {
        Console.WriteLine("Please enter file name ending with .txt: ");
        string _fileName = Console.ReadLine();
        
        if (_fileName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
        {
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                outputFile.WriteLine(CalculateTotalPoints(goals));
                foreach (Goal goal in goals)
                {
                    if (goal is ChecklistGoal)
                    {
                        ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                        outputFile.WriteLine($"{goal.GetType()}:;{checklistGoal.GetGoalName()};{checklistGoal.GetDescription()};{checklistGoal.GetPoints()};{checklistGoal.GetBonus()}/{checklistGoal.GetNumCompleted()};{checklistGoal.GetCompleteTimes()};{checklistGoal.GetCompleted()};{checklistGoal.GetCompletedPoints()}");
                    }
                    else
                    {
                        outputFile.WriteLine($"{goal.GetType()}:;{goal.GetGoalName()};{goal.GetDescription()};{goal.GetPoints()};{goal.GetCompleted()};{goal.GetCompletedPoints()}");

                    }
                }
            }
        } else {
            //Add .txt extension if not included in name
            string newFileName = _fileName + ".txt";
            using (StreamWriter outputFile = new StreamWriter(newFileName))
            {
                outputFile.WriteLine(CalculateTotalPoints(goals));
                foreach (Goal goal in goals)
                {
                    if (goal is ChecklistGoal)
                    {
                        ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                        outputFile.WriteLine($"{goal.GetType()}:;{checklistGoal.GetGoalName()};{checklistGoal.GetDescription()};{checklistGoal.GetPoints()};{checklistGoal.GetBonus()}/{checklistGoal.GetNumCompleted()};{checklistGoal.GetCompleteTimes()};{checklistGoal.GetCompleted()};{checklistGoal.GetCompletedPoints()}");
                    }
                    else
                    {
                        outputFile.WriteLine($"{goal.GetType()}:;{goal.GetGoalName()};{goal.GetDescription()};{goal.GetPoints()};{goal.GetCompleted()};{goal.GetCompletedPoints()}");

                    }
                }
            }
        }
    }

    //Load a saved file
    public void LoadGoalsFile(List<Goal> goals)
    {
        while (true) {
            Console.WriteLine("Please enter the name of the file to load (ending with .txt): ");
            string filename = Console.ReadLine();

            if (!filename.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Your file's name must end with .txt. Please try again");
                continue; // This prompts the user for filename again
            }

            if (File.Exists(filename)) {
                string[] lines = File.ReadAllLines(filename);
                lines = lines.Skip(1).ToArray();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(";");
                    string name = parts[1];
                    string desc = parts[2];
                    int goalPoints = int.Parse(parts[3]);
                    if (parts[4].Contains("/"))
                    {
                        string bonus = parts[4];
                        string[] checklistParts = bonus.Split("/");
                        bonus = checklistParts[0];
                        int numCompleted = int.Parse(checklistParts[1]);
                        int bonusInt = int.Parse(bonus);
                        int num = int.Parse(checklistParts[1]);
                        bool isComplete = bool.Parse(parts[6]);
                        int completedPoints = int.Parse(parts[7]);
                        goals.Add(new ChecklistGoal(name, desc, numCompleted, num, bonusInt, isComplete, goalPoints, completedPoints));

                    }
                    else
                    {
                        int completedPoints = int.Parse(parts[5]);
                        bool isComplete = bool.Parse(parts[4]);
                        string goalType = parts[0];
                        if (goalType == "SimpleGoal:")
                        {
                            goals.Add(new SimpleGoal(name, desc, goalPoints, isComplete, completedPoints));

                        }
                        else
                        {
                            goals.Add(new EternalGoal(name, desc, goalPoints, isComplete, completedPoints));

                        }
                    }
                }
                break;
            }
            else
            {
                Console.WriteLine("The file you are trying to open doesn't exist.");
            }
        }
        
    }



    //Calculate user points
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
