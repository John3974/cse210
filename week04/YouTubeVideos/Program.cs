<<<<<<< HEAD

using System;
using System.Collections.Generic;
public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}


public class Video
{
    public string _Title { get; set; }
    public string _Author { get; set; }
    public int _Length { get; set; }

    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        _Title = title;
        _Author = author;
        _Length = length;
        Comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video(
            "Introduction to Python",
            "John Otieno",
            620);

        Video video2 = new Video(
            "Learning C# Classes",
            "Code Academy",
            845);

        Video video3 = new Video(
            "Machine Learning Basics",
            "Data Science Hub",
            930);

        Video video4 = new Video(
            "How to Build a Website",
            "Web Development Channel",
            720);


        // Add comments to Video 1
        video1.Comments.Add(new Comment(
            "David",
            "This was a very helpful introduction to Python."));

        video1.Comments.Add(new Comment(
            "Mary",
            "I finally understand variables after watching this."));

        video1.Comments.Add(new Comment(
            "Peter",
            "Great explanation and easy to follow."));

        video1.Comments.Add(new Comment(
            "Sarah",
            "Looking forward to the next video."));


        // Add comments to Video 2
        video2.Comments.Add(new Comment(
            "James",
            "The explanation of classes was really clear."));

        video2.Comments.Add(new Comment(
            "Grace",
            "I learned something new today."));

        video2.Comments.Add(new Comment(
            "Daniel",
            "The examples made the topic much easier."));

        video2.Comments.Add(new Comment(
            "Ann",
            "Great C# tutorial!"));


        // Add comments to Video 3
        video3.Comments.Add(new Comment(
            "Michael",
            "Machine learning is becoming very interesting."));

        video3.Comments.Add(new Comment(
            "Lucy",
            "The explanation of training data was excellent."));

        video3.Comments.Add(new Comment(
            "Brian",
            "Please make another video about regression."));

        video3.Comments.Add(new Comment(
            "Kevin",
            "Very useful introduction to machine learning."));


        // Add comments to Video 4
        video4.Comments.Add(new Comment(
            "John",
            "HTML and CSS are much easier to understand now."));

        video4.Comments.Add(new Comment(
            "Susan",
            "The website example looks great."));

        video4.Comments.Add(new Comment(
            "Alex",
            "I will use these ideas in my own project."));

        video4.Comments.Add(new Comment(
            "Robert",
            "Thanks for sharing this tutorial."));


        // Put all videos into a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };


        // Display each video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {video._Title}");
            Console.WriteLine($"Author: {video._Author}");
            Console.WriteLine($"Length: {video._Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
=======

using System;
using System.Collections.Generic;
public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}


public class Video
{
    public string _Title { get; set; }
    public string _Author { get; set; }
    public int _Length { get; set; }

    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        _Title = title;
        _Author = author;
        _Length = length;
        Comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video(
            "Introduction to Python",
            "John Otieno",
            620);

        Video video2 = new Video(
            "Learning C# Classes",
            "Code Academy",
            845);

        Video video3 = new Video(
            "Machine Learning Basics",
            "Data Science Hub",
            930);

        Video video4 = new Video(
            "How to Build a Website",
            "Web Development Channel",
            720);


        // Add comments to Video 1
        video1.Comments.Add(new Comment(
            "David",
            "This was a very helpful introduction to Python."));

        video1.Comments.Add(new Comment(
            "Mary",
            "I finally understand variables after watching this."));

        video1.Comments.Add(new Comment(
            "Peter",
            "Great explanation and easy to follow."));

        video1.Comments.Add(new Comment(
            "Sarah",
            "Looking forward to the next video."));


        // Add comments to Video 2
        video2.Comments.Add(new Comment(
            "James",
            "The explanation of classes was really clear."));

        video2.Comments.Add(new Comment(
            "Grace",
            "I learned something new today."));

        video2.Comments.Add(new Comment(
            "Daniel",
            "The examples made the topic much easier."));

        video2.Comments.Add(new Comment(
            "Ann",
            "Great C# tutorial!"));


        // Add comments to Video 3
        video3.Comments.Add(new Comment(
            "Michael",
            "Machine learning is becoming very interesting."));

        video3.Comments.Add(new Comment(
            "Lucy",
            "The explanation of training data was excellent."));

        video3.Comments.Add(new Comment(
            "Brian",
            "Please make another video about regression."));

        video3.Comments.Add(new Comment(
            "Kevin",
            "Very useful introduction to machine learning."));


        // Add comments to Video 4
        video4.Comments.Add(new Comment(
            "John",
            "HTML and CSS are much easier to understand now."));

        video4.Comments.Add(new Comment(
            "Susan",
            "The website example looks great."));

        video4.Comments.Add(new Comment(
            "Alex",
            "I will use these ideas in my own project."));

        video4.Comments.Add(new Comment(
            "Robert",
            "Thanks for sharing this tutorial."));


        // Put all videos into a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };


        // Display each video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {video._Title}");
            Console.WriteLine($"Author: {video._Author}");
            Console.WriteLine($"Length: {video._Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
>>>>>>> e0a3d674394e1dd1c8c05d09e00dfd83aa905b50
}