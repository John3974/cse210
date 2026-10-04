using System;

public class Listing : Activity
{
    private string[] _prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths you have?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "What are some things you are grateful for?"
    };

    public Listing(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void Run()
    {
        DisplayActivity();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];

        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items.");
        DisplayEndingMassage();
    }
}