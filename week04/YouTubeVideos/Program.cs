using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Unboxing the Future", "Bar-Jona", 320);
        video1.AddComment(new Comment("Krinton", "Loved the product reveal!"));
        video1.AddComment(new Comment("Ben", "Very informative."));
        video1.AddComment(new Comment("Smulls", "Can't wait to try it."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 5 Gadgets of 2025", "GadgetGuru", 450);
        video2.AddComment(new Comment("Dan", "Great list!"));
        video2.AddComment(new Comment("Agyeiwaa", "Where can I buy #3?"));
        video2.AddComment(new Comment("Daisy", "Awesome video."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Behind the Scenes: Product Launch", "BrandInsider", 275);
        video3.AddComment(new Comment("George", "Loved the transparency."));
        video3.AddComment(new Comment("Hannah", "Very cool insights."));
        video3.AddComment(new Comment("Kwasi", "More videos like this please!"));
        videos.Add(video3);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
