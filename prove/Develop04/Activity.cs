using System;
using System.Threading;

public abstract class Activity
{
    public int Duration { get; set; }

    public void Start()
    {
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        DisplayStartMessage();
        PerformActivity();
        DisplayEndMessage();
    }

    protected abstract void PerformActivity();

    protected void DisplayStartMessage()
    {
        Console.WriteLine("Starting activity...");
        Thread.Sleep(2000);
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine($"Activity complete. Duration: {Duration} seconds.");
        Thread.Sleep(2000);
    }

    protected void ShowSpinner()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write(".");
            Thread.Sleep(5000);
        }
        Console.WriteLine();
    }
}
