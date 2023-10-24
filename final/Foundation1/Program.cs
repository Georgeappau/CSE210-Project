using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create and populate Video objects
        Video video1 = new Video("Introduction to C#", "Clifford Ashong", 600);
        video1.AddComment("Alice", "Great video!");
        video1.AddComment("Bob", "I learned a lot.");
        videos.Add(video1);

        Video video2 = new Video("Web Development Basics", "Debbie Palmer", 720);
        video2.AddComment("Charlie", "Nice explanation.");
        video2.AddComment("George", "Thank you so much for this explanation");
        video2.AddComment("Eli", "Could you make a video on HTML elements?");
        videos.Add(video2);

        Video video3 = new Video("Loops in C#", "Abrante pa", 900);
        video3.AddComment("Emily", "Helped me in my studies.");
        video3.AddComment("Frank", "Excellent content.");
        videos.Add(video3);

        // Display video information and comments
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
