using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    // int i = 0;

    public void AddEntry(Entry newEntry)
    {
        // // ALL THE CODE THAT WAS ALREADY HERE:
        
        // Entry entry = new Entry();
        // entry.Display();

        // // entry._date = 

        // // _entries.Add(entryElement);

        // _entries.Add(entry);
        // // _entries.Add(entry._promptText);
        // // _entries.Add(entry._entryText);

        // // THE SUGGESTED CORRECTIONS FROM CHATGPT:

        // _entries.Add(newEntry); // Add the provided entry to the list

        // Changes I had to make in my code:
        // I took line 18 (_entries.Add(entry);) and changed the parameter of
        // the Add() function to be the same as the method, which is newEntry:

        _entries.Add(newEntry);

        // A test code:
        // Console.WriteLine("The code worked just fine.");

        // Testing printing the entries from here:

        // while (i != _entries.Count)
        // {
        // Console.WriteLine($"{_entries[i]._date}-{_entries[i]._promptText}-{_entries[i]._entryText}");
        // i = i + 1;
        // }

        // int i = 0;
        // while (i < _entries.Count)
        // {
        //     Entry entry = _entries[i];
        //     Console.WriteLine($"Date: {entry._date}");
        //     Console.WriteLine($"Prompt: {entry._promptText}");
        //     Console.WriteLine($"Entry: {entry._entryText}");
        //     i++;
        // }

    }

    public void DisplayAll()
    {
        // My attempts to make it work, using or not
        // the ideas from ChatGPT:

        // Console.WriteLine(_entries[0]);
        // int i = 0;
        // Entry entry = _entries[i];

        // while (i != _entries.Count)
        // {
        // Console.WriteLine(entry._date);
        // Console.WriteLine(entry._promptText);
        // Console.WriteLine(entry._entryText);

        // i = i + 1;
        // }
        
        // Entry entry = _entries[0];

        // Console.WriteLine($"{entry._date}-{entry._promptText}-{entry._entryText}");

        // while (i != _entries.Count)
        // {
        // Console.WriteLine($"{_entries[i]._date}-{_entries[i]._promptText}-{_entries[i]._entryText}");
        // i = i + 1;
        // }

        // Code given by ChatGPT:

        // foreach (Entry entry in _entries)
        // {
        //     Console.WriteLine($"Date: {entry._date}");
        //     Console.WriteLine($"Prompt: {entry._promptText}");
        //     Console.WriteLine($"Entry: {entry._entryText}");
        //     Console.WriteLine();
        // }
        
        // A suggestion from it to check if the List is empty

        // if (_entries.Count == 0)
        // {
        //     Console.WriteLine("This list is empty");
        //     Console.WriteLine(_entries.Count);
        // }

        // The ChatGPT code ends here

        // This message should appear in case this method
        // was working:

        // Console.WriteLine("The DisplayAll() method is working");
        // Console.WriteLine();

        // Console.WriteLine($"Date: {_entries[0]._date}");

        // That is based on a way I created, based on my
        // knowledge in Python, to iterate through all the
        // items of type Entry inside the _entries list, along
        // with some ideas I got from ChatGPT of how to do
        // it using less code:

        int i = 0;

        while (i != _entries.Count)
        {
        // //     // This comment below was just a copied code
        // //     // from ChatGPT while I was trying to access
        // //     // the _entries list from this method.

        // //     // Console.WriteLine($"Date: {_entries[i]._date}");
        // //     // Console.WriteLine($"Prompt: {_entries[i]._promptText}");
        // //     // Console.WriteLine($"Entry: {_entries[i]._entryText}");
        // //     // Console.WriteLine();

            Entry entry = _entries[i];

            Console.WriteLine(entry._date);
            Console.WriteLine(entry._promptText);
            Console.WriteLine(entry._entryText);
            Console.WriteLine();

            i = i + 1;
        }
    }

    public void SaveToFile(string file)
    {
        // Console.WriteLine("What name do you want to give to the file?");
        // string file = Console.ReadLine();

        int i = 0;

        using(StreamWriter outputFile = new StreamWriter(file))

        while (i != _entries.Count)
        {
            Entry entry = _entries[i];

            outputFile.WriteLine(entry._date);
            outputFile.WriteLine(entry._promptText);
            outputFile.WriteLine(entry._entryText);
            outputFile.WriteLine();

            i = i + 1;
        }
    }

    public void LoadFromFile(string file)
    {

    }
}
