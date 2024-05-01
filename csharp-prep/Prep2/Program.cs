using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string strGrade = Console.ReadLine();

        int grade = int.Parse(strGrade);
        
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        if (grade >= 70)
        {  
            Console.WriteLine("Congratulations! You were approved!");
        }

        else
        {
            Console.WriteLine("Sorry. You didn't get a passing grade. Please try again next semester");
        }

        Console.Write($"You've got an/a {letter}");
    }
}