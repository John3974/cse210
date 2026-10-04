<<<<<<< HEAD
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
=======
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
>>>>>>> e0a3d674394e1dd1c8c05d09e00dfd83aa905b50
}