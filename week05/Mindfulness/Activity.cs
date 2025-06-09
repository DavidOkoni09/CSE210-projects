using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;


    public Activity(string description, string name)
    {
        _name = name;
        _description = description;
        
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}\n \n{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good Job!!!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} with a duration of {_duration} seconds");
        Thread.Sleep(1000);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };

        for (int i = seconds; i > 0; i--)
        {
            for (int j = 0; j < spinner.Length; j++)
            {
                Console.Write(spinner[j]);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }


    }
}