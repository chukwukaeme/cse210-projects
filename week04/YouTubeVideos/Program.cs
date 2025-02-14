using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

                List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Cook Pasta", "Chef Alex", 300);
        video1.AddComment(new Comment("John", "Great recipe!"));
        video1.AddComment(new Comment("Sarah", "Tried it, loved it!"));
        video1.AddComment(new Comment("Mike", "What sauce do you recommend?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("C# Basics for Beginners", "Code Academy", 600);
        video2.AddComment(new Comment("Alice", "Very helpful tutorial."));
        video2.AddComment(new Comment("Bob", "Can you make a video on OOP?"));
        video2.AddComment(new Comment("Emma", "This was exactly what I needed!"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Travel Vlog: Paris", "Wanderlust Diaries", 900);
        video3.AddComment(new Comment("Chris", "Beautiful shots!"));
        video3.AddComment(new Comment("Sophie", "Paris is on my bucket list!"));
        video3.AddComment(new Comment("David", "Love your content."));
        videos.Add(video3);

        // Display all videos
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}