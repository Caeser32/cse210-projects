using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // This is video 1
        Video video1 = new Video("Video Title 1", "Author 1", 300);
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "Nice content."));
        video1.AddComment(new Comment("User3", "Very helpful."));
        videos.Add(video1);

        // This is video 2
        Video video2 = new Video("Video Title 2", "Author 2", 450);
        video2.AddComment(new Comment("User4", "Very informative."));
        video2.AddComment(new Comment("User5", "Loved it!"));
        video2.AddComment(new Comment("User6", "Excellent explanation."));
        videos.Add(video2);

        // This is video 3
        Video video3 = new Video("Video Title 3", "Author 3", 600);
        video3.AddComment(new Comment("User7", "Amazing work!"));
        video3.AddComment(new Comment("User8", "Keep it up!"));
        video3.AddComment(new Comment("User9", "Awesome content."));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}, Author: {video.GetAuthor()}, Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            Console.WriteLine();
        }
    }
}
