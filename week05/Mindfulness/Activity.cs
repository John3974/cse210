<<<<<<< HEAD
using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // return methods


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _duration = 0;

    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void SetName(string name)
    {
        _name = name;
    }


    // displays the name and description of the activity
    public void DisplayActivity()
    {
        Console.Clear();
        Console.WriteLine($"Activity:{_name}" + $"\nDescription:{_description}");

        // ask user and set  for the duration of the activity
        Console.WriteLine("How long ,in seconds, would you like for your session?");
        Console.WriteLine("Prepare to begin and pause for several seconds.");

        while (!int.TryParse(Console.ReadLine(), out _duration))
        {
            Console.WriteLine("Please enter a number between 10 and 120 seconds.");
        }
        Console.WriteLine();
        Console.WriteLine($"You have selected {_duration} seconds for your session.");
        Console.WriteLine("Prepare to begin and pause for several seconds.");

        ShowSpinner(5);
        Console.WriteLine();

    }

    public void DisplayEndingMassage()
    {
        // ending message ,the activity done and the length of time spent on the activity
        Console.WriteLine();
        Console.WriteLine("Well done!!");

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_name} activity that took {_duration} seconds.");

        CountDown(5);
        Console.WriteLine();


    }
    // show some sort of animation to the user such as a spinner,countdown,or period to show that the program is running
    protected string CountDown(int v)
    {
        Console.WriteLine("Get ready to begin in:");
        for (int i = v; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.WriteLine();


        }
        return "";
    }
    public void ShowSpinner(int v)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        DateTime endTime = DateTime.Now.AddSeconds(v);
        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            index = (index + 1) % spinner.Length;

            if (index >= spinner.Length)
            {
                index = 0;

            }
        }

    }
    public bool TimeRemaining(DateTime endTime, int duration)

    {
        DateTime currentTime = DateTime.Now;
        return currentTime < endTime.AddSeconds(duration);
    }

}




=======
using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // return methods


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _duration = 0;

    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void SetName(string name)
    {
        _name = name;
    }


    // displays the name and description of the activity
    public void DisplayActivity()
    {
        Console.Clear();
        Console.WriteLine($"Activity:{_name}" + $"\nDescription:{_description}");

        // ask user and set  for the duration of the activity
        Console.WriteLine("How long ,in seconds, would you like for your session?");
        Console.WriteLine("Prepare to begin and pause for several seconds.");

        while (!int.TryParse(Console.ReadLine(), out _duration))
        {
            Console.WriteLine("Please enter a number between 10 and 120 seconds.");
        }
        Console.WriteLine();
        Console.WriteLine($"You have selected {_duration} seconds for your session.");
        Console.WriteLine("Prepare to begin and pause for several seconds.");

        ShowSpinner(5);
        Console.WriteLine();

    }

    public void DisplayEndingMassage()
    {
        // ending message ,the activity done and the length of time spent on the activity
        Console.WriteLine();
        Console.WriteLine("Well done!!");

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_name} activity that took {_duration} seconds.");

        CountDown(5);
        Console.WriteLine();


    }
    // show some sort of animation to the user such as a spinner,countdown,or period to show that the program is running
    protected string CountDown(int v)
    {
        Console.WriteLine("Get ready to begin in:");
        for (int i = v; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.WriteLine();


        }
        return "";
    }
    public void ShowSpinner(int v)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        DateTime endTime = DateTime.Now.AddSeconds(v);
        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            index = (index + 1) % spinner.Length;

            if (index >= spinner.Length)
            {
                index = 0;

            }
        }

    }
    public bool TimeRemaining(DateTime endTime, int duration)

    {
        DateTime currentTime = DateTime.Now;
        return currentTime < endTime.AddSeconds(duration);
    }

}




>>>>>>> e3116b5edf44eaf85cd3dd2af547e25baf806e3f
