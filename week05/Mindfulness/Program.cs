using System;



public class Program
{


    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        // menu system that allows for choice of activities
        DisplayMenu();
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Mindfulness Activities:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");



        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    Breathing breathingActivity = new Breathing(
                        "Breathing",
                        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
                        0
                    );
                    breathingActivity.Run();
                    break;

                case 2:
                    Reflection reflectionActivity = new Reflection(
                        "Reflection",
                        "This activity will help you reflect on times in your life when you have shown strength and resilience.",
                        0
                    );
                    reflectionActivity.Run();
                    break;

                case 3:
                    Listing listingActivity = new Listing(
                        "Listing",
                        "This activity will help you reflect on the good things in your life by having you list things related to a specific prompt.",
                        0
                    );
                    listingActivity.Run();
                    break;

                case 4:
                    Console.WriteLine("Thank you for using the Mindfulness program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                    Activity temp = new Activity("Menu", "", 0);
                    temp.ShowSpinner(2);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Please enter a number.");
            Activity temp = new Activity("Menu", "", 0);
            temp.ShowSpinner(2);
        }
    }











}


