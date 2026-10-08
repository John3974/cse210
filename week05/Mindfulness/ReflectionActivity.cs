<<<<<<< HEAD
using System;

public class Reflection : Activity
{
    private string[] _prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you learned something important."
    };

    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was finished?",
        "What did you learn from this experience?",
        "How can you use this experience in the future?",
        "What made this experience special?"
    };

    public Reflection(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void Run()
    {
        DisplayActivity();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];

        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Length)];

            Console.WriteLine();
            Console.WriteLine(question);
            ShowSpinner(5);
        }

        DisplayEndingMassage();
    }
=======
using System;

public class Reflection : Activity
{
    private string[] _prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you learned something important."
    };

    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was finished?",
        "What did you learn from this experience?",
        "How can you use this experience in the future?",
        "What made this experience special?"
    };

    public Reflection(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void Run()
    {
        DisplayActivity();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];

        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Length)];

            Console.WriteLine();
            Console.WriteLine(question);
            ShowSpinner(5);
        }

        DisplayEndingMassage();
    }
>>>>>>> e3116b5edf44eaf85cd3dd2af547e25baf806e3f
}