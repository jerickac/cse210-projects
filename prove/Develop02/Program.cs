using System;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        Journal journal = new Journal();
        // Entry entry = new Entry();

        while (answer != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string strAnswer = Console.ReadLine();

            int answerInLoop = int.Parse(strAnswer);
            answer = answerInLoop;

            // Journal journal = new Journal();
            // Entry entry = new Entry();


            if (answer == 1)
            {
                // // ALL THE CODE THAT WAS ALREADY HERE:
                // Entry entry = new Entry();
                // // entry.Display();

                // // DateTime theCurrentTime = DateTime.Now;
                // // entry._date = theCurrentTime.ToShortDateString();
                // // Console.WriteLine(_date);

                // // entry.Display();

                // Journal journal = new Journal();
                // journal.AddEntry(entry);

                // // THE SUGGESTED CORRECTIONS FROM CHATGPT:
                // Entry entry = new Entry(); // Create a new Entry object
                // entry.Display(); // This will prompt the user for input and set entry properties

                // Journal journal = new Journal();
                // journal.AddEntry(entry); // Add the created entry to the journal

                // The code that I filtered from everything I had already written:
                // That is just exactly what ChatGPT was suggesting
                Entry entry = new Entry();
                entry.Display();

                // Journal journal = new Journal();
                journal.AddEntry(entry);
            }

            else if (answer == 2)
            {
                Console.WriteLine();

                // Journal journal = new Journal();
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
        }

    }
}
