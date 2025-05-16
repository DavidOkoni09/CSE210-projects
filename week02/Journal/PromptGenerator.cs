using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int point = random.Next(_prompts.Count);
        string randomPrompt = _prompts[point];
        return randomPrompt;
    }
}