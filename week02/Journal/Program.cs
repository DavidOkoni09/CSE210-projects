using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program.");
        
        Journal myJournal = new Journal();
        PromptGenerator prompt1 = new PromptGenerator();
        prompt1._prompts.Add("What was your goal for today");
        prompt1._prompts.Add("What impactful thing(s) did you do today?");
        prompt1._prompts.Add("Were there any challenges that came up throughout your day?");
        prompt1._prompts.Add("Did any happy or sad event happen in your day? What was it?");
        prompt1._prompts.Add("Did you meet any notable/interesting person today?");

            int response = 0;
        

            while (!(response == 5))
            {
                Console.WriteLine("Please choose one of the following options:");
                Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
                Console.Write("What will you like to do? ");
                response = int.Parse(Console.ReadLine());

                if (response == 1)
                {
                    string finalPrompt = prompt1.GetRandomPrompt();
                    Console.WriteLine(finalPrompt);
                    Console.Write("> ");
                    string userEntry = Console.ReadLine();
                    
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Today.ToString("d");
                    newEntry._entryText = userEntry;
                    newEntry._promptText = finalPrompt;
                    myJournal.AddEntry(newEntry);
                }

                else if (response == 2)
                {
                    myJournal.DisplayAll();
                }

                else if (response == 3)
                {
                    Console.Write("What is the file to load? ");
                    string file = Console.ReadLine();
                    myJournal.LoadFromFile(file);
                }

                else if (response == 4)
                {
                    Console.Write("Choose a file name: ");
                    string fileName = Console.ReadLine();
                    myJournal.SaveToFile(fileName);
                }
            }
    }
}