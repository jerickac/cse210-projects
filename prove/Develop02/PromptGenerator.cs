public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    
    // int j = 0;
    int randomNumber = 0;

    public string GetRandomPrompt()
    {
        _prompts.Add("What is one little miracle the Lord performed in my life today?");
        _prompts.Add("Who was an angel on earth for me today and why?");
        _prompts.Add("What Christlike atribute was I able to demonstrate today?");
        _prompts.Add("Who was I able to help today and how?");
        _prompts.Add("What was the funniest moment in the day?");
        
        Random rnd = new Random(); 

        for (int j = 0; j < 1; j++);
        randomNumber = rnd.Next(5);
        // Console.WriteLine(_prompts[randomNumber]);

        return _prompts[randomNumber];
    }
}