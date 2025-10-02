public class Resume
{
    public string _name { get; set; }
    public List<Job> njobs { get; set; } = new List<Job>();

    public void display()
    {
        Console.WriteLine($"resume of {_name}");
        Console.Write($"jobs: ");
        foreach (Job job in njobs)
        {
            job.display();
        }
    }
}
