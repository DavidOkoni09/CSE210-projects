using System;
using System.Formats.Asn1;

public class BreathingActivity : Activity
{
    public BreathingActivity(string description, string name) : base(description, name)
    {

    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(2);

        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe out slowly...");
            ShowCountDown(6);
            Console.WriteLine();
        }
    }
}