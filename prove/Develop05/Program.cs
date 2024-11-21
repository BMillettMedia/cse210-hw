using System;

class Program
{
    static void Main(string[] args)
    {
        EternalQuest quest = new EternalQuest();

        Console.WriteLine("Welcome to Eternal Quest!");

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score and Level");
            Console.WriteLine("5. Save Progress");
            Console.WriteLine("6. Load Progress");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nSelect Goal Type:");
                    Console.WriteLine("1. Simple Goal (Max 5 Points)");
                    Console.WriteLine("2. Eternal Goal (Max 20 Points)");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Your choice: ");
                    string goalType = Console.ReadLine();

                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter Points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (goalType == "1")
                    {
                        quest.AddGoal(new SimpleGoal(title, description, points));
                    }
                    else if (goalType == "2")
                    {
                        Console.Write("Enter Points Per Record (Max 20): ");
                        int pointsPerRecord = int.Parse(Console.ReadLine());
                        quest.AddGoal(new EternalGoal(title, description, pointsPerRecord));
                    }
                    else if (goalType == "3")
                    {
                        Console.Write("Enter Total Tasks: ");
                        int totalTasks = int.Parse(Console.ReadLine());
                        Console.Write("Enter Bonus Points: ");
                        int bonusPoints = int.Parse(Console.ReadLine());
                        quest.AddGoal(new ChecklistGoal(title, description, points, totalTasks, bonusPoints));
                    }
                    break;

                case "2":
                    Console.Write("Enter Goal Title to Record: ");
                    string goalTitle = Console.ReadLine();
                    quest.RecordEvent(goalTitle);
                    break;

                case "3":
                    quest.DisplayGoals();
                    break;

                case "4":
                    quest.DisplayScoreAndLevel();
                    break;

                case "5":
                    Console.Write("Enter Filename to Save: ");
                    string saveFile = Console.ReadLine();
                    quest.SaveProgress(saveFile);
                    break;

                case "6":
                    Console.Write("Enter Filename to Load: ");
                    string loadFile = Console.ReadLine();
                    quest.LoadProgress(loadFile);
                    break;

                case "7":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
