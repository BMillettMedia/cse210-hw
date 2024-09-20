using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade:");
        string value = Console.ReadLine();

        int value = int.Parse(value);

        string letter = "";

        if (value >= 90)
        {
            letter ="A";

        }
       
        else if (value >= 80)
        {
            letter = "B";
        }
        else if (value >= 70)
        {
            letter = "C";
        }
        else if (value >= 60)
        {
            letter = "D";
        }
         else {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is: {letter}");

        if(value >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else 
        {
            Console.WriteLine("Better Luck Next time!");
        }
    }
}