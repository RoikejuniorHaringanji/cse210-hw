using System;

/// Represents a single journal entry.
public class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }
    /// Displays the journal entry in a readable format.
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine("------------------------------");
    }
    /// Converts the journal entry to a CSV format.
    public string ToCsvFormat()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
}