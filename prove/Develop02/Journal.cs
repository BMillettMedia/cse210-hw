//Journal Database
//Write new and overwrite files.

using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Attributes
    private List<Entry> entries;

    // Constructor
    public Journal()
    {
        entries = new List<Entry>();
    }

    // Behaviors
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();  // Clear current entries
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                entries.Add(entry);
            }
        }
    }
}
