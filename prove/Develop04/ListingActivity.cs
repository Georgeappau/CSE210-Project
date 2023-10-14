
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> PromptsList = new List<string>();
    public List<string> ResponsesList = new List<string>();

    public ListingActivity(int duration, string description, string activityName, int initialPauseDuration, int finalPauseDuration, string endingMessage)
        : base(duration, description, activityName, initialPauseDuration, finalPauseDuration, endingMessage)
    {
        PromptsList.Add("Who are people that you appreciate?");
        PromptsList.Add("What are personal strengths of yours?");
        PromptsList.Add("Who are people that you have helped this week?");
        PromptsList.Add("When have you felt the Holy Ghost this month?");
        PromptsList.Add("Who are some of your personal heroes?");
    }

    public void StartListingActivity()
    {
        StartActivity();
        Console.Clear();
        Console.WriteLine("Get ready to start!");
        InitialPause();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Random random = new Random();
        int randomIndex = random.Next(PromptsList.Count);
        Console.WriteLine(PromptsList[randomIndex]);
        PromptsList.RemoveAt(randomIndex);
        InitialPause();
        Console.WriteLine("You may begin in:");
        Countdown(InitialPauseDuration);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            ResponsesList.Add(Console.ReadLine());
        }
        int lengthListedItems = ResponsesList.Count;
        Console.WriteLine($"You listed {lengthListedItems} items!");
        Console.WriteLine();
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
