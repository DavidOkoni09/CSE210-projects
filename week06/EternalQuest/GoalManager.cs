using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    private int _level;
    private int _nextLevelThreshold;

    public GoalManager()
    {
        _score = 0;
        _level = 1;
        _nextLevelThreshold = 1000;
    }

    public void Start()
    {
        bool running = true;

    while (running)
    {
        Console.WriteLine("\n=== Eternal Quest Menu ===");
        DisplayPlayerInfo(); // Show current score

        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Save Goals");
        Console.WriteLine("5. Load Goals");
        Console.WriteLine("6. Quit");
        Console.Write("Choose an option (1-6): ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                CreateGoal();
                break;

            case "2":
                ListGoalDetails();
                break;

            case "3":
                RecordEvent();
                break;

            case "4":
                Console.Write("Enter filename to save to: ");
                string saveFile = Console.ReadLine();
                SaveGoals(saveFile);
                Console.WriteLine("Goals saved.");
                break;

            case "5":
                Console.Write("Enter filename to load from: ");
                string loadFile = Console.ReadLine();
                LoadGoals(loadFile);
                Console.WriteLine("Goals loaded.");
                break;

            case "6":
                running = false;
                break;

            default:
                Console.WriteLine("Invalid choice. Try again.");
                break;
        }
    }

    Console.WriteLine("Thanks for using Eternal Quest!");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}  | Level: {_level} (Next: {_nextLevelThreshold} pts)");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose goal type: ");
        string type = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
            _goals.Add(new SimpleGoal(name, desc, points));
        else if (type == "2")
            _goals.Add(new EternalGoal(name, desc, points));
        else if (type == "3")
        {
            Console.Write("Enter target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
        else
            Console.WriteLine("Invalid goal type.");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record:");
        ListGoalNames();
        Console.Write("Enter goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int earnedPoints = _goals[index].RecordEvent();
            _score += earnedPoints;
            Console.WriteLine($"You earned {earnedPoints} points!");

            CheckLevelUp();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    public void CheckLevelUp()
    {
        while (_score >= _nextLevelThreshold)
        {
            _level++;
            Console.WriteLine($"Congratulations!! Level Up! You are now Level {_level}!");
            _nextLevelThreshold += _level * 1000;
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine($"{_score}, {_level}, {_nextLevelThreshold}");
            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GeStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        string[] header = lines[0].Split(',');
        _score = int.Parse(header[0]);
        _level = int.Parse(header[1]);
        _nextLevelThreshold = int.Parse(header[2]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            if (type == "SimpleGoal")
            {
                var goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                if (bool.Parse(data[3])) goal.RecordEvent();
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "ChecklistGoal")
            {
                var goal = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[3]));
                for (int j = 0; j < int.Parse(data[5]); j++) goal.RecordEvent();
                _goals.Add(goal);
            }
        }
    }
}