using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter score (0–100): ");
        if (!int.TryParse(Console.ReadLine(), out int score) || score < 0 || score > 100)
        {
            Console.WriteLine("Invalid input. Must be an integer 0–100.");
            return;
        }

        string grade;
        if (score >= 90)         grade = "A";
        else if (score >= 80)    grade = "B";
        else if (score >= 70)    grade = "C";
        else if (score >= 60)    grade = "D";
        else                     grade = "F";

        Console.WriteLine($"Your grade is {grade}.");
    }
}
