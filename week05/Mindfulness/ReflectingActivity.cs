using System;
using System.ComponentModel;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string description, string name) : base(description, name)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
    }



    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(2);

        Console.WriteLine("Consider the folowing prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions.");
        ShowSpinner(3);
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(5);
            Console.WriteLine();
        }
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---\n");
    }
    
    public void DisplayQuestion()
    {
        Console.WriteLine($"> {GetRandomQuestion()}");
    }
}