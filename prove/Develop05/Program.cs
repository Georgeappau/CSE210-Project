using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        MainMenu mainmenu = new MainMenu();
        GoalCategory category = new GoalCategory();
        List<Goal> goals = new List<Goal>();
        Utility controler = new Utility();

        while (choice <= 5)
        {
            choice = mainmenu.GetOption(); //Calls the GetOption() function and stores its return value in the choice variable

            switch (choice)
            {
                // Create new goal
                case 1:
                    int goalChoice = 0;
                    while (goalChoice != 4)
                    {
                        goalChoice = category.GetCategory();
                        // Deal with type of goal
                        switch (goalChoice)
                        {
                            // Simple goal
                            case 1:
                                Console.Clear();
                                SimpleGoal simpleGoal = new SimpleGoal();
                                simpleGoal.CreateGoal();
                                goals.Add(simpleGoal);
                                break;
                            // Eternal goal
                            case 2:
                                Console.Clear();
                                EternalGoal eternalGoal = new EternalGoal();
                                eternalGoal.CreateGoal();
                                goals.Add(eternalGoal);
                                break;
                            // Checklist goal
                            case 3:
                                Console.Clear();
                                ChecklistGoal checklistGoal = new ChecklistGoal();
                                checklistGoal.CreateGoal();
                                goals.Add(checklistGoal);
                                break;
                            default:
                                Console.WriteLine($"Invalid option");
                                break;
                        }
                    }
                    break;
                // Display goals
                case 2:
                    Console.Clear();

                    foreach (Goal goal in goals)
                    {
                        if (goal is ChecklistGoal)
                        {
                            ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                            Console.WriteLine($"{checklistGoal.PrintIsComplete()} {checklistGoal.GetGoalName()} ({checklistGoal.GetDescription()}) --- Currently completed: {checklistGoal.GetProgress()}/{checklistGoal.GetDesiredCompletions()} times");
                        }
                        else
                        {
                            Console.WriteLine($"{goal.PrintIsComplete()} {goal.GetGoalName()} ({goal.GetDescription()})");

                        }
                    }
                    break;
                // Save goal
                case 3:
                    controler.WriteFile(goals);
                    break;
                // Load goal
                case 4:
                    controler.LoadFile(goals);
                    break;
                // Record eventl
                case 5:
                    Console.Clear();
                    Console.WriteLine("The goals are:");
                    int index = 1;
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine(index + ". " + goal.GetGoalName());
                        index++;
                    }
                    Console.WriteLine("Which of these did you complete?");
                    int completedChoice = int.Parse(Console.ReadLine());
                    if (completedChoice >= 1 && completedChoice <= goals.Count)
                    {
                        Goal completedGoal = goals[completedChoice - 1];
                        completedGoal.RecordEvent();
                        Console.WriteLine("Sit on my right hand side you righteous servant.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;
                // Quit program
                default:
                    Console.WriteLine("Program quit successfully. Thank you!.");
                    break;
                    // Console.WriteLine($"Invalid option");
                    //break;
            }
        }
    }
}
