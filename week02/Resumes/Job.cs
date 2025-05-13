Job job = new Job();
job._companyName = "Microsoft";
job._jobTitle = "Data Analyst";
job._startYear = 2022;
job._endYear = 2025;
job.ShowResult();

public class Job
{
    // Keeps track of the company, job title, start year, and end year.
    public string _companyName = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    public Job()
    {
    }

    public void ShowResult()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}.");
    }
}