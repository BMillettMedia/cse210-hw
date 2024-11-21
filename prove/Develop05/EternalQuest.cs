using System;
using System.Collections.Generic;
using System.IO;

public class EternalQuest
{
    private List<Goal> _goals;
    private int _score;
    private int _level;

    public EternalQuest()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalTitle)
    {
        Goal goal = _goals.Find(g => g.Title.Equals(goalTitle, StringComparison.OrdinalIgnoreCase));
        if (goal != null)
        {
            goal.RecordProgress();
            _score += goal.Points;
            UpdateLevel();
        }
        else
        {
            Console.WriteLine($"Goal '{goalTitle}' not found.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nGoals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.ToString());
        }
    }

    public void DisplayScoreAndLevel()
    {
        Console.WriteLine($"\nTotal Score: {_score}");
        Console.WriteLine($"Current Level: {_level}");
    }

    private void UpdateLevel()
    {
        if (_score >= 100)
        {
            _level = 3;
        }
        else if (_score >= 50)
        {
            _level = 2;
        }
        else
        {
            _level = 1;
        }
    }

    public void SaveProgress(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_level);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.ToString());
            }
        }
        Console.WriteLine("Progress saved!");
    }

    public void LoadProgress(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _level = int.Parse(lines[1]);
            _goals.Clear();
            Console.WriteLine("Progress loaded!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
