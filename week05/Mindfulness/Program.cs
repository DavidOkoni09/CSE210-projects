// I added an activity log to the program to track how many times each activity was done.
using System;

class Program
{
    static Dictionary<string, int> activityLog = new Dictionary<string, int>()
    {
        {"Breathing Activity", 0},
        {"Reflecting Activity", 0},
        {"Listing Activity", 0}
    };
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                Console.Clear();
                BreathingActivity a1 = new BreathingActivity("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing Activity");
                a1.DisplayStartingMessage();
                Console.Clear();
                a1.Run();
                a1.DisplayEndingMessage();

                activityLog["Breathing Activity"]++;
            }

            if (choice == 2)
            {
                Console.Clear();
                ReflectingActivity r1 = new ReflectingActivity("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflecting Activity");
                r1.DisplayStartingMessage();
                Console.Clear();
                r1.Run();
                r1.DisplayEndingMessage();

                activityLog["Reflecting Activity"]++;
            }

            if (choice == 3)
            {
                Console.Clear();
                ListingActivity l1 = new ListingActivity("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing Activity");
                l1.DisplayStartingMessage();
                Console.Clear();
                l1.Run();
                l1.DisplayEndingMessage();

                activityLog["Listing Activity"]++;
            }

            if (choice == 4)
            {
                Console.WriteLine("\nActivity Summary:");
                foreach (var entry in activityLog)
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value} time(s)");
                }
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}