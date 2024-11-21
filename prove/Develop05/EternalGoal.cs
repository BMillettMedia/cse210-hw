using System;

public class EternalGoal : Goal
{
    private int _pointsPerRecord;

    public EternalGoal(string title, string description, int pointsPerRecord)
        : base(title, description, Math.Min(pointsPerRecord, 20))
    {
        _pointsPerRecord = Math.Min(pointsPerRecord, 20);
    }

    public override void RecordProgress()
    {
        Points += _pointsPerRecord;
        Console.WriteLine($"Progress recorded for '{Title}'. You earned {_pointsPerRecord} points. Total: {Points} points.");
    }

    public override string GetProgressStatus()
    {
        return $"Eternal Progress: {Points} points";
    }

    public override string ToString()
    {
        return $"[∞] {Title}: {Description} (Points Per Record: {_pointsPerRecord})";
    }
}
