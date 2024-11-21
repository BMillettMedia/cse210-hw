using System;

public class ChecklistGoal : Goal
{
    private int _totalTasks;
    private int _completedTasks;
    private int _bonusPoints;

    public ChecklistGoal(string title, string description, int points, int totalTasks, int bonusPoints)
        : base(title, description, points)
    {
        _totalTasks = totalTasks;
        _bonusPoints = bonusPoints;
        _completedTasks = 0;
    }

    public override void RecordProgress()
    {
        if (_completedTasks < _totalTasks)
        {
            _completedTasks++;
            Points += Points;
            Console.WriteLine($"Task completed for '{Title}'. {_completedTasks}/{_totalTasks} tasks completed.");

            if (_completedTasks == _totalTasks)
            {
                Points += _bonusPoints;
                IsCompleted = true;
                Console.WriteLine($"Goal '{Title}' fully completed! Bonus: {_bonusPoints} points.");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{Title}' is already fully completed.");
        }
    }

    public override string GetProgressStatus()
    {
        return IsCompleted
            ? "[X]"
            : $"[ ] {_completedTasks}/{_totalTasks} tasks completed";
    }

    public override string ToString()
    {
        return $"{GetProgressStatus()} {Title}: {Description} (Points: {Points}, Bonus: {_bonusPoints})";
    }
}
