using System.Runtime.InteropServices;

public class Prompt {
    public List<string> _prompts = new List<string>{
        "Who was the most interesting person I interacted with today.?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are you grateful for today?",
        "What is a challenge you faced today, and how did you overcome it?",
        "Describe a moment that made you smile or laugh today.",
        "What is a goal you're currently working toward, and what progress have you made?",
        "What's something new you learned today?",
        "Write about a book, article, or podcast you encountered today and its impact on you.",
        "Reflect on a recent accomplishment, no matter how small it may seem.",
        "Is there something you're worried about or anxious about? Write about it, and consider ways to address it.",
        "Who did you connect with today, and how did it make you feel?",
        "What's a habit or behavior you'd like to change or improve, and what steps can you take to work on it?",
        "Describe a place you'd like to visit or a dream you have for the future.",
        "Write about a decision you made today and how you came to that decision.",
        "Share an act of kindness you witnessed or performed today.",
        "Reflect on your physical health and well-being. Did you engage in any physical activities today?",
        "What are your intentions or goals for tomorrow?"
    };

    public Prompt(){}

    public string GetRandomPromt(){
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

  
}
