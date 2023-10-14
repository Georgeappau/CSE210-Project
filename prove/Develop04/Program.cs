using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine("Please select one of the following activities: ");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity\n2. Listing Activity\n3. Reflection Activity\n4. Quit");
            // Console.WriteLine("2. Listing Activity");
            // Console.WriteLine("3. Reflection Activity");
            // Console.WriteLine("4. Quit");

            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity(
                    10,
                    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
                    "Breathing",
                    3,
                    3,
                    "Great job! You have completed the Breathing Activity.",
                    5,
                    5
                );
                breathingActivity.StartBreathingActivity();
            }
            else if (userChoice == 2)
            {
                ListingActivity listingActivity = new ListingActivity(
                    10,
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                    "Listing",
                    3,
                    3,
                    "Great job! You have completed the Listing Activity."
                );
                listingActivity.StartListingActivity();
            }
            else if (userChoice == 3)
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity(
                    10,
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                    "Reflection",
                    3,
                    3,
                    "You have completed the Reflection Activity."
                );
                reflectionActivity.StartReflectionActivity();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Thank you for practicing mindfulness. Have a great day!");
                Activity activity = new Activity(10, "", "", 3, 3, "");
                activity.InitialPause();
                break;
            }
        }
    }
}
