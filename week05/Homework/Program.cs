using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {




        Assignment assignment = new Assignment("Alice Johnson", "History Project");
        Console.WriteLine(assignment.GetSummary());


        WritingAssignment writingAssignment = new WritingAssignment("John Doe", "English Essay", "The Great Gatsby");

        Console.WriteLine(writingAssignment.GetWritingInformation());

        MathAssignment mathAssignment = new MathAssignment("section 2.3", "1-10", "Jane Smith", "Algebra Homework");
        Console.WriteLine(mathAssignment.GetHomeworkList())


    }
}