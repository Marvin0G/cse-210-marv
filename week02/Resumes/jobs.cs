public class Job
{
    public string _companyname { get; set; }
    public string _jobTitle { get; set; }
    public int _startYear { get; set; }
    public int _endYear { get; set; }
    
    public void display()
    {
        Console.WriteLine($"{_jobTitle}  ({_companyname})  {_startYear} - {_endYear}  ");
    }


}
