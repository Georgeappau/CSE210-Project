using System;

public class Activity
{
    protected int Duration;
    protected string Description;
    protected string ActivityName;
    protected int InitialPauseDuration;
    protected int FinalPauseDuration;
    private string EndingMessage;

    public Activity(int duration, string description, string activityName, int initialPauseDuration, int finalPauseDuration, string endingMessage)
    {
        Duration = duration;
        Description = description;
        ActivityName = activityName;
        InitialPauseDuration = initialPauseDuration;
        FinalPauseDuration = finalPauseDuration;
        EndingMessage = endingMessage;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {ActivityName} Activity.");
        Console.WriteLine();
        Console.WriteLine(Description);
        Console.WriteLine();
        // Console.WriteLine("How long in seconds would you like your session?");
        // Duration = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayHoldAnimation(int pauseSeconds)
    {
        string[] spinner = { "|", "/", "-"};
        for (int i = 0; i < pauseSeconds; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }

    public void InitialPause(int duration = 10)
    {
        DisplayHoldAnimation(duration);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine(EndingMessage);
        DisplayHoldAnimation(10);
    }

    private const int MaxDuration = 60;

    public void SetDuration()
    {
        Console.WriteLine("Enter the duration in seconds (60 seconds at most): ");
        int duration;
        if (int.TryParse(Console.ReadLine(), out duration))
        {
            if (duration > MaxDuration)
            {
                Console.WriteLine("Duration is too long. Please choose a shorter duration.");
                SetDuration(); 
            }
            else
            {
                Duration = duration;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid duration.");
            SetDuration(); 
        }
    }

    public void StartActivity()
    {
        Console.Clear();
        DisplayStartingMessage();
        SetDuration();
    }

}
