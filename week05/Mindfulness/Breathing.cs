public class Breathing : Activity
{


    // DisplaysActivity
    public Breathing(string name, string description, int duration) : base(name, description, duration)
    {
        Console.WriteLine("Welcome to The Breathing Activity");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        // message to show series of alternating between breathing in and out for a set amount of time
        // inherit from activity - countdown method
    }

    public void Run()
    {
        DisplayActivity();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (TimeRemaining(endTime, GetDuration()))
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in ....");
            CountDown(4);

            if (!TimeRemaining(endTime, GetDuration()))
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Breathe out.....");
            CountDown(4);
        }

        Console.WriteLine();
        DisplayEndingMassage();
    }
}