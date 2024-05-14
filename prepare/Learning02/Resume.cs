public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    int i = 0;

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        while (i != _jobs.Count)
        {
            Console.WriteLine($"{_jobs[i]._jobTitle} ({_jobs[i]._company}) {_jobs[i]._startYear}-{_jobs[i]._endYear}");
            i = i + 1;
        }   
    }
}