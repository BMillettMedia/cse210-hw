using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your First Name?");
    string FName= Console.ReadLine();
    Console.WriteLine("What is your Last Name?");
    string LName= Console.ReadLine();

    Console.WriteLine($"Your name is {FName} {LName}.");
    }
    
}