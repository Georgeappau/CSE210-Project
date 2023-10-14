// using System;
// using System.Collections.Generic;

// public class ReflectionActivity : Activity
// {
//     private List<string> PromptsList = new List<string>();
//     private List<string> QuestionsList = new List<string>()
//     {
//         "Why was this experience meaningful to you?",
//         "Have you ever done anything like this before?",
//         "How did you get started?",
//         "How did you feel when it was complete?",
//         "What made this time different than other times when you were not as successful?",
//         "What is your favorite thing about this experience?",
//         "What could you learn from this experience that applies to other situations?",
//         "What did you learn about yourself through this experience?",
//         "How can you keep this experience in mind in the future?"
//     };

//     public ReflectionActivity(int duration, string description, string activityName, int initialPauseDuration, int finalPauseDuration, string endingMessage)
//         : base(duration, description, activityName, initialPauseDuration, finalPauseDuration, endingMessage)
//     {
//         PromptsList.Add("Think of a time when you stood up for someone else.");
//         PromptsList.Add("Think of a time when you did something really difficult.");
//         PromptsList.Add("Think of a time when you helped someone in need.");
//         PromptsList.Add("Think of a time when you did something truly selfless.");
//     }

//     public void StartReflectionActivity()
//     {
//         StartActivity();
//         Console.Clear();
//         Console.WriteLine("Get ready to start!");
//         InitialPause();
//         Random random = new Random();
//         int randomIndex = random.Next(PromptsList.Count);
//         Console.WriteLine(PromptsList[randomIndex]);
//         PromptsList.RemoveAt(randomIndex);
//         InitialPause();
//         Console.WriteLine("When you have something in mind, press enter to continue.");
//         Console.ReadLine();
//         Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
//         Countdown(InitialPauseDuration);
//         DateTime startTime = DateTime.Now;
//         DateTime endTime = startTime.AddSeconds(Duration);

//         while (DateTime.Now < endTime)
//         {
//             Random randomQuestion = new Random();
//             int randomQuestionIndex = randomQuestion.Next(QuestionsList.Count);
//             Console.WriteLine("> " + QuestionsList[randomQuestionIndex]);
//             QuestionsList.RemoveAt(randomQuestionIndex);
//             InitialPause(20);
//             Console.WriteLine();
//         }
//         Console.WriteLine("Well Done!");
//         InitialPause();
//         DisplayEndingMessage();
//     }

//     public void Countdown(int seconds)
//     {
//         for (int i = seconds; i >= 1; i--)
//         {
//             Console.Write(i + "...");
//             System.Threading.Thread.Sleep(1000);
//         }
//         Console.WriteLine();
//     }
// }
using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> PromptsList = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> QuestionsList = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future"
    };

    public ReflectionActivity(int duration, string description, string activityName, int initialPauseDuration, int finalPauseDuration, string endingMessage)
        : base(duration, description, activityName, initialPauseDuration, finalPauseDuration, endingMessage)
    {
    }

    public void StartReflectionActivity()
    {
        StartActivity();
        Console.Clear();
        Console.WriteLine("Get ready to start!");
        InitialPause();

        while (PromptsList.Count > 0)
        {
            int randomIndex = new Random().Next(PromptsList.Count);
            string prompt = PromptsList[randomIndex];
            PromptsList.RemoveAt(randomIndex);
            DisplayPrompt(prompt);
            AskQuestions();
        }

        DisplayEndingMessage();
    }

    private void DisplayPrompt(string prompt)
    {
        InitialPause();
        Console.WriteLine(prompt);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    private void AskQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Countdown(InitialPauseDuration);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);

        while (DateTime.Now < endTime && QuestionsList.Count > 0)
        {
            int randomQuestionIndex = new Random().Next(QuestionsList.Count);
            string question = QuestionsList[randomQuestionIndex];
            QuestionsList.RemoveAt(randomQuestionIndex);
            DisplayQuestion(question);
        }

        Console.WriteLine("Well Done!");
        InitialPause();
    }

    private void DisplayQuestion(string question)
    {
        Console.WriteLine("> " + question);
        InitialPause(20);
        Console.WriteLine();
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
