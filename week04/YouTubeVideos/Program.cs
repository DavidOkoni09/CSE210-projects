using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video { _title = "Dangers of Smoking", _author = "Agrinya Owokoni", _length = 10.5 };
        video1.AddComment(new Comment("Alice", "Very Informative, thanks!"));
        video1.AddComment(new Comment("Harry", "Woooow!!!"));
        video1.AddComment(new Comment("Phil", "Thumbs"));
        videoList.Add(video1);

        Video video2 = new Video { _title = "Creating a LinkedIn Profile", _author = "Morray Joshua", _length = 9 };
        video2.AddComment(new Comment("Janet", "Really helpful"));
        video2.AddComment(new Comment("May", "Worked liked magic"));
        video2.AddComment(new Comment("Christopher", "Thumbs"));
        videoList.Add(video2);

        Video video3 = new Video { _title = "Intro to python", _author = "Carl Halley", _length = 30.5 };
        video3.AddComment(new Comment("David", "Nice Explanation!"));
        video3.AddComment(new Comment("Layla", "Loved your examples"));
        video3.AddComment(new Comment("Bob", "Worthwhile!!"));
        videoList.Add(video3);

        Video video4 = new Video { _title = "Understanding Abstraction in Programming", _author = "Agrinya Owokoni", _length = 27.9 };
        video4.AddComment(new Comment("Clinton", "Very Informative!"));
        video4.AddComment(new Comment("Osborn", "Makes so much sense"));
        video4.AddComment(new Comment("Mary", "Finally get it, thanks!!"));
        videoList.Add(video4);
        
        foreach (Video video in videoList)
        {
            video.Display();
        }
        
    }
}