// As the creativity, I made the program to randomly select words from a those that are not already hidden.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Proverbs", 3, 5);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press the enter key or type quit to end. ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;
            
            scripture.HideRandomWords(1);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("All words hidden.");
        
    }
}