//For the stretch goal I added a difficulty selector to the code to and a way to restart the program once the scripture is completely hidden. 

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Scripture dictionaries based on difficulty
        Dictionary<Reference, string> easyScriptures = new Dictionary<Reference, string>()
        {
            { new Reference("John", 3, "16"), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life." },
            { new Reference("Genesis", 1, "1"), "In the beginning God created the heaven and the earth." }
        };

        Dictionary<Reference, string> mediumScriptures = new Dictionary<Reference, string>()
        {
            { new Reference("Proverbs", 3, "5-6"), "5 Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths" },
            { new Reference("Philippians", 4, "13"), "I can do all things through Christ which strengtheneth me." }
        };

        Dictionary<Reference, string> hardScriptures = new Dictionary<Reference, string>()
        {
            { new Reference("Moroni", 10, "4"), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost." },
            { new Reference("1 Nephi", 3, "7"), "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them." }
           
        };

        bool running = true;
        while (running)
        {
            // User selects difficulty
            Console.WriteLine("Choose a difficulty level (1: Easy, 2: Medium, 3: Hard): ");
            int difficulty = int.Parse(Console.ReadLine());

            Dictionary<Reference, string> selectedDifficulty = null;

            switch (difficulty)
            {
                case 1:
                    selectedDifficulty = easyScriptures;
                    break;
                case 2:
                    selectedDifficulty = mediumScriptures;
                    break;
                case 3:
                    selectedDifficulty = hardScriptures;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid difficulty.");
                    continue;
            }

            // Select a random scripture from the chosen difficulty
            var randomScripture = GetRandomScripture(selectedDifficulty);
            Scripture scripture = new Scripture(randomScripture.Key, randomScripture.Value);

            // Scripture hiding and displaying loop
            while (true)
            {
                scripture.DisplayScripture();

                Console.WriteLine("\nPress Enter to hide words. Press Enter again once all words are hidden to return to the menu or type 'quit' to exit.");
                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                {
                    running = false;
                    break;
                }
                else
                {
                    if (!scripture.HideRandomWords())
                    {
                        Console.Clear();
                        Console.WriteLine("All words have been hidden.");
                        break;
                    }
                }
            }

            if (!running)
                break;
        }

        Console.WriteLine("Goodbye!");
    }

    // Helper method to randomly select a scripture from a dictionary
    static KeyValuePair<Reference, string> GetRandomScripture(Dictionary<Reference, string> scriptures)
    {
        Random random = new Random();
        int index = random.Next(scriptures.Count);
        foreach (var scripture in scriptures)
        {
            if (index-- == 0)
                return scripture;
        }
        return default;
    }
}
