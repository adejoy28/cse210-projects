using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Python Full Course for free 🐍 (2024)", "Tim Carton", "23:34");

        video1.AddComment(new Comment("@floofybear", "Bro makes a Free 12 Hour well explained course and makes it a fundraiser. A real Gigachad."));
        video1.AddComment(new Comment("@Royallight", "A journal of my progress in python as a newbie with zero experience in coding and im 13"));
        video1.AddComment(new Comment("@number12fxbro", "I was literally about to study Python and you just posted this video."));

        Video video2 = new Video("Introverts are the worst", "Twyse Ereme", "17:00");

        video2.AddComment(new Comment("@ismailtaofiq5873", "Who else noticed almost all twyse videos are indoors"));
        video2.AddComment(new Comment("@folashadejuliana626", "The peace attached to this kind of lifestyle is unmatched."));
        video2.AddComment(new Comment("@yalaking01", "He has said it all: only introverts can fully understand this explanation."));
        
        Video video3 = new Video("C# Full Course : C# Tutorial for Beginners", "Derek Banas", "8:58:36"); 
        
        video3.AddComment(new Comment("@philrice2995", "At the end you said 'if you watch it to the end leave a comment'. I watched it until the end. It was a very nice introduction to the C# language. Thanks for making it."));
        video3.AddComment(new Comment("@codingpeanuts", "C# - the unsung hero of coding languages. Sure, it might not be the 'it' choice for startups, but its robustness, updated features, and amazing community make it a rockstar in its own right."));
        video3.AddComment(new Comment("@maksimsimeonov9541", "I am sixteen now and learned so many things because of you thank you so much"));
        video3.AddComment(new Comment("@valentine5397", "Started this video in the morning (at 1.5x speed) and I finished it at 8 PM. This is a great resource to get a good grounding of C# very quickly, especially for experienced developers looking to pickup the language. Thank you Derek."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        int s_n = 0;
        foreach (var video in videos)
        { 
          Console.WriteLine(s_n += 1);
          Console.WriteLine($"Title: {video.GetTitle()}");
          Console.WriteLine($"Author: {video.GetAuthor()}");
          Console.WriteLine($"Length: {video.GetLength()}");
          Console.WriteLine($"Comments: {video.GetNumberOfComments()}");

          foreach (var comment in video.GetComments())
          {
            Console.WriteLine(comment.GetComment());
            // Console.WriteLine($"{comment.GetNameOfCommenter()}: {comment.GetCommentText()}");
          }

          Console.WriteLine("");
        }
    }
}