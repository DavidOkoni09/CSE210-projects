using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _random;

    public ListingActivity(string description, string name) : base(description, name)
    {
        _count = 0;
        _random = new Random();
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(2);

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        List<string> replies = GetListFromUser(GetDuration());
        _count = replies.Count;
    

        Console.WriteLine($"You listed {_count} items!");
    }

    public void GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    public List<string> GetListFromUser(int duration)
    {
        List<string> replies = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                replies.Add(input);
            }
        }
        return replies;
    }
}