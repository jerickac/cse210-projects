public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        PromptGenerator prompt = new PromptGenerator();
        _promptText = prompt.GetRandomPrompt();
        Console.WriteLine(_promptText);

        _entryText = Console.ReadLine();
        // Console.WriteLine(_entryText);

        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        Console.WriteLine(_date);
    }
}
