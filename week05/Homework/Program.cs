using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment m1 = new MathAssignment("Samuel Bennett", "Multiplication", "Section 7.3", "Problems 8-19");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        WritingAssignment w1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}