using System;

partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2018;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Editor";
        

        Console.WriteLine(job1._companyName);
    }
}