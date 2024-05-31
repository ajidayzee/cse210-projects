using System;
using System.Collections.Generic;


    


class MainProgram
{
    static void Main(string[] args)
    {
        // Create some comments
        Comment comment1 = new Comment("Woodruff", "Great video!");
        Comment comment2 = new Comment("Sam", "Very informative.");
        Comment comment3 = new Comment("Kimball", "Thanks for sharing.");

        // Create some videos and add comments to them
        Video video1 = new Video("How to Survive Ibadan Nigeria", "Mondayz TV", 600);
        video1.addComment(comment1);
        video1.addComment(comment2);

        Video video2 = new Video("Introduction to C#", "Code Pen", 800);
        video2.addComment(comment1);
        video2.addComment(comment3);

        Video video3 = new Video("Learning Python", "Code Guru", 750);
        video3.addComment(comment2);
        video3.addComment(comment3);

        // Add videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display the information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.getTitle());
            Console.WriteLine("Author: " + video.getAuthor());
            Console.WriteLine("Length: " + video.getLength() + " seconds");
            Console.WriteLine("Number of Comments: " + video.getCommentCount());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.getComments())
            {
                Console.WriteLine("  - " + comment.getName() + ": " + comment.getText());
            }
            Console.WriteLine();
        }
    }
}