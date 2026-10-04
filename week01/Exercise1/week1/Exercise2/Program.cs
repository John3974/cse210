using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int percentGrade = int.Parse(grade);

        string letterGrade;
        if (percentGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (percentGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (percentGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (percentGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}.");
        if (percentGrade >= 70)
        {
            Console.WriteLine("You have passed the course.");
        }
        else
        {
            Console.WriteLine("You have failed the course.");
        }


    }
}



