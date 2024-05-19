// I added another option, "5. Read Motivation Quote", which calls a method in Journal that calls
// a function that generate a quote from some church authority about journaling. I think that 
// sometimes people just don't understand the importante of writing on a journal. However, a quote
// from a prophet, for example, can be a good motivation and reminder of its importante

using System;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        while (answer != 6)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Read Motivation Quote");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");

            string strAnswer = Console.ReadLine();

            int answerInLoop = int.Parse(strAnswer);
            answer = answerInLoop;

            if (answer == 1)
            {
                Entry entry = new Entry();
                entry.Display();

                journal.AddEntry(entry);
            }

            else if (answer == 2)
            {
                Console.WriteLine();

                journal.DisplayAll();
            }

            else if (answer == 4)
            {
                Console.WriteLine("What name do you want to give to the file?");
                string file = Console.ReadLine();   
                journal.SaveToFile(file);
            }

            else if (answer == 3)
            {
                Console.WriteLine("What file do you want to open?");
                string file = Console.ReadLine();   
                journal.LoadFromFile(file);
            }

            else if (answer == 5)
            {
                journal.DisplayMotivationQuote();
            }
        }

    }
}
