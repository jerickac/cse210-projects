public class WritingAssignment : Assignment
{
    private String _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    
    public String GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    } 
}