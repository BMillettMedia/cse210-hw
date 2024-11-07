using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected string name;
    protected string description;
    protected int duration;

    public MindfulnessActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"\nStarting {name}: {description}");
        Console.Write("Enter duration of activity in seconds: ");
        duration = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000);
    }

    public void EndActivity()
    {
        Console.WriteLine("Great job! You have completed the activity.");
        Console.WriteLine($"Activity: {name}, Duration: {duration} seconds.");
        Thread.Sleep(2000);
    }

    public abstract void RunActivity();
}
