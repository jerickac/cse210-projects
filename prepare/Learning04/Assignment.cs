public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment()
    {
        _studentName = "Anonymous";
        _topic = "Subject";
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}