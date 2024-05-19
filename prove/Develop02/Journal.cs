using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _motivationQuote;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        int i = 0;

        while (i != _entries.Count)
        {
            Console.WriteLine($"Date: {_entries[i]._date}");
            Console.WriteLine($"Prompt Text: {_entries[i]._promptText}");
            Console.WriteLine($"Entry Text: {_entries[i]._entryText}");
            Console.WriteLine();
            i = i + 1;
        }
    }

    public void SaveToFile(string file)
    {
        int i = 0;

        using(StreamWriter outputFile = new StreamWriter(file))

        while (i != _entries.Count)
        {
            Entry entry = _entries[i];

            outputFile.Write(entry._date);
            outputFile.Write(",");
            outputFile.Write(entry._promptText);
            outputFile.Write(",");
            outputFile.WriteLine(entry._entryText);
            i = i + 1;
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];

            Console.Write("Date: ");
            Console.WriteLine(date);
            Console.Write("Prompt Text: ");
            Console.WriteLine(promptText);
            Console.Write("Entry Text: ");
            Console.WriteLine(entryText);
            Console.WriteLine();

            Entry entry = new Entry();

            entry._date = date;
            entry._promptText = promptText;
            entry._entryText = entryText;

            _entries.Add(entry);
        }
    }

    public void DisplayMotivationQuote()
    {
        MotivationQuoteGenerator motivationQuote = new MotivationQuoteGenerator();
        _motivationQuote = motivationQuote.GetRandomMotivationQuote();
        Console.WriteLine();
        Console.WriteLine(_motivationQuote);
        Console.WriteLine();
    }
}
