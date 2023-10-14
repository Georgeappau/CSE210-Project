using System;

public class BreathingActivity : Activity
{
    private int _breathInSeconds;
    private int _breatheOutSeconds;

    public BreathingActivity(int duration, string description, string activityName, int initialPauseDuration, int finalPauseDuration, string endingMessage, int breathIn, int braathOut)
        : base(duration, description, activityName, initialPauseDuration, finalPauseDuration, endingMessage)
    {
        _breathInSeconds = breathIn;
        _breatheOutSeconds = braathOut;
    }

    public void StartBreathingActivity()
    {
        StartActivity();

        int breathCount = Duration / (_breathInSeconds + _breatheOutSeconds);
        Console.Clear();
        Console.WriteLine("Get ready to start!");
        InitialPause();
        for (int i = 0; i < breathCount; i++)
        {
            Console.WriteLine("Breathe in...");
            Countdown(_breathInSeconds);
            Console.WriteLine("Breathe out...");
            Countdown(_breatheOutSeconds);
        }
        DisplayEndingMessage();
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i + "...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
