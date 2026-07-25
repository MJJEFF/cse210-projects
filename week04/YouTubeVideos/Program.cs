using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Unboxing the New Smartphone", "TechReviewer99", 612);
        video1.AddComment(new Comment("Alice", "Great review, very detailed!"));
        video1.AddComment(new Comment("Brian", "I didn't know this phone had that feature."));
        video1.AddComment(new Comment("Carla", "Can you compare this to last year's model?"));
        video1.AddComment(new Comment("Devin", "The camera samples looked amazing."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("10 Minute Home Workout", "FitWithJenna", 630);
        video2.AddComment(new Comment("Ella", "This really got my heart rate up!"));
        video2.AddComment(new Comment("Frank", "Perfect for a quick morning routine."));
        video2.AddComment(new Comment("Grace", "Can you do a beginner version of this?"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("How Bread Is Made", "BakingBasics", 745);
        video3.AddComment(new Comment("Henry", "I never knew the process was this involved."));
        video3.AddComment(new Comment("Isla", "Trying this recipe tonight!"));
        video3.AddComment(new Comment("Jack", "Your videos are so relaxing to watch."));
        video3.AddComment(new Comment("Kara", "What kind of flour do you recommend?"));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Top 5 Travel Destinations for 2026", "WanderWithMe", 890);
        video4.AddComment(new Comment("Liam", "Adding these to my bucket list!"));
        video4.AddComment(new Comment("Mia", "Great tips on budgeting for travel."));
        video4.AddComment(new Comment("Noah", "Have you been to Southeast Asia?"));
        videos.Add(video4);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}