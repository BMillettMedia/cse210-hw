using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points)
        : base(title, description, Math.Min(points, 5)) { }

    public override void RecordProgress()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            Console.WriteLine($"Goal '{Title}' completed! You earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{Title}' is already completed.");
        }
    }

    public override string GetProgressStatus()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }

    public override string ToString()
    {
        return $"{GetProgressStatus()} {Title}: {Description} (Points: {Points})";
    }
}
