//Journal Database and entry system

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new journal();
        Prompt promptGenerator = new Prompt();
        bool running = true;

        //Main menu start
        while (running)
        {
            Console.WriteLine("Welcome to your daily journal.");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");

            string choice = Console.Readline();

            //switch menu logic
            switch(choice)
            {   //Write new journal entry
                case "1":
                    string prompt = promptGenerator.GetPrompt();
                    Console.WriteLine($"Here is an Idea for you today! Prompt:{prompt}");
                    
                    //input response from user
                    Console.WriteLine(">");
                    strong response = Console.Readline();

                    //new entry storage
                    Entry entry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response);
                    journal.AddEntry(entry);
                    break;

                //Display Current Journal Entry
                case "2":
                    journal.DisplayJournal();
                    break;

                //Save Journal to File
                //check for overwrite warning?
                case "3":
                    Console.WriteLine("Enter filename to save:")
                    string saveFilename. = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

                //Load Journal from File
                case "4":
                Console.WriteLine("Enter filename to load:");
                string loadFilename=Console.ReadLine();
                journal.LoadFromFile(loadFilename);
                break;

                //option 5
                case "5":
                running=false;
                default: 
                    Console.WriteLine("Thank you. Goodbye!");
                    break;
            }
        }
    }
}