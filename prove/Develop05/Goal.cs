using System;

public abstract class Goal
{
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; protected set; }
    public int Points { get; protected set; }

    public Goal(string title, string description, int points)
    {
        Title = title;
        Description = description;
        Points = points;
        IsCompleted = false;
    }

    public abstract void RecordProgress();
    public abstract string GetProgressStatus();

    public override string ToString()
    {
        return $"[ ] {Title}: {Description} (Points: {Points})";
    }
}
