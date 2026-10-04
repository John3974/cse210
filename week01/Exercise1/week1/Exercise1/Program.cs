using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.WriteLine($"Hello {firstName}!");

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Nice to meet you, {firstName} {lastName}!");
    }
}