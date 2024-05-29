public class MathAssignment : Assignment
{
    private String _textbookSection;
    private String _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public String GetHomeworkList()
    {
        return $"{_textbookSection} - {_problems}";
    }
}