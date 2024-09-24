using System;

class Program
{
    static void Main(string[] args)
    {
        static string UserName()
        {
        Console.WriteLine("Hello and thank you for using this program!");
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        }

        static int UserNumber ()
        {
        Console.WriteLine($"Hello {name} What is your favorite number?");
        string number = Console.ReadLine();
        number = int.Parse(userNumber);

        }
        
        static int PromptUserNumber()
        {
            int square = number * number;
            return number;
        }


        Console.WriteLine($"{name}, the square of your favorite number is {square}");
    }
}