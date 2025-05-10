using System;
using System.Collections.Generic;
//using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int digitsNew;
        int largest = 0;

        do
        {
            Console.Write("Enter number: ");
            string digits = Console.ReadLine();
            digitsNew = int.Parse(digits);
            numbers.Add(digitsNew);

        }  while (digitsNew != 0);
        
           numbers.RemoveAt(numbers.Count - 1);
           int sum = numbers.Sum();
           Console.WriteLine($"The sum is: {sum}");
           double average = numbers.Average();
           Console.WriteLine($"The average is: {average}");

           foreach (int number in numbers)
           {
                if (number > largest)
                {
                    largest = number;
                }
           }
           Console.WriteLine($"The largest number is: {largest}");
        


    }
}