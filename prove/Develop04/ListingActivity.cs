using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private static readonly string[] Prompts = {
        "List people you appreciate.",
        "List your strengths."
    };

    protected override void PerformActivity()
    {
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Length)]);
        ShowSpinner();
        
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter item: ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items.");
    }
}
