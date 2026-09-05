using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();

        int usernumber = -1;
        while (usernumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userString = Console.ReadLine();
            usernumber = int.Parse(userString);
            if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }
        }

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
        }


        else
        {
            Console.WriteLine("No numbers were entered.");
        }
        int max = numbers[0];
        int min = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        Console.WriteLine($"The maximum is: {max}");
        Console.WriteLine($"The minimum is: {min}");
    }
}