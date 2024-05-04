using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<float> numbers = new List<float>();
        float someNumber = 1;
        float total = 0;
        float highest = 0;
        float average = 0;

        while (someNumber != 0)
        {
            Console.Write("Enter number: ");
            string strSomeNumber = Console.ReadLine();
            float someNumberInLoop = float.Parse(strSomeNumber);

            someNumber = someNumberInLoop;

            total = total + someNumber;

            numbers.Add(someNumber);

        }

        average = total / (numbers.Count - 1);

        float max = numbers.Max();

        foreach (float number in numbers)
        {
            Console.Write($"{number}, ");
        }
        
        Console.WriteLine();
        Console.WriteLine($"The sum of this list is {total}");
        Console.WriteLine($"The average of this list is {average}");
        Console.WriteLine($"{max} is the highest number in the list");
    }
}