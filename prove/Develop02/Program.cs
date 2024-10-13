
//Journal Database and entry system
using System;
using System.Collections.Generic;  // Needed for handling lists in other classes

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompt promptGenerator = new Prompt();
        bool running = true;

        // Main menu start
        while (running)
        {
            Console.WriteLine("Welcome to your daily journal.");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            // Switch menu logic
            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetPrompt();
                    Console.WriteLine($"Here is an idea for you today! Prompt: {prompt}");

                    // Input response from user
                    Console.WriteLine(">");
                    string response = Console.ReadLine();

                    // New entry storage
                    Entry entry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response);
                    journal.AddEntry(entry);
                    break;

                case "2":
                    Console.WriteLine("Enter filename to display:");
    string displayFilename = Console.ReadLine();
    
    if (File.Exists(displayFilename))
    {
        string[] fileContent = File.ReadAllLines(displayFilename);
        Console.WriteLine("Contents of the file:");
        foreach (string line in fileContent)
        {
            Console.WriteLine(line);
        }
    }
    else
    {
        Console.WriteLine("File does not exist.");
    }
                    break;

                case "3":
                    Console.WriteLine("Enter filename to save:");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

                case "4":
                    Console.WriteLine("Enter filename to load:");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Thank you. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
