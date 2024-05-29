using System;

class Program
{
    
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        Assignment assignment1 = new Assignment("John Bennet", "Fractions");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Micaela", "Trigonometry", "7.3", "3-10, 20-21");
        Console.WriteLine(assignment2.GetHomeworkList());
    }
}