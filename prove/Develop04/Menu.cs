using System;

public class Menu
{
    public void Display()
    {
        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Meditation Activity");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    //activity = new MeditationActivity(duration); 
                    // Pass duration
                    Console.Write("Enter meditation duration in seconds: ");
                    if (int.TryParse(Console.ReadLine(), out int duration))
                    {
                        activity = new MeditationActivity(duration); // Pass duration
                    }
                    else
                    {
                        Console.WriteLine("Invalid duration. Please enter a number.");
                        continue;
                    }
                    break;
                case "5":
                    Console.WriteLine("Exiting program. Thank you!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    continue;
            }

            if (activity != null)
            {
                try
                {
                    activity.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
