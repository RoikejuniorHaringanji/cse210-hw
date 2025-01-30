using System;
using System.Collections.Generic;
using System.IO;

/// Represents a journal containing multiple entries.
public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    /// Adds a new entry to the journal.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    /// Displays all entries in the journal.
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
    /// Saves all journal entries to a file.
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine(entry.ToCsvFormat());
            }
        }
    }

    /// Loads journal entries from a file, replacing current entries.
    public void LoadFromFile(string fileName)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
        }
    }
}
