using System;
using System.Collections.Generic;
using System.IO;

// Base class for all goal types
abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public bool IsCompleted { get; protected set; }
    
    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    public abstract void RecordEvent(ref int score);
    public abstract string GetStatus();
    public abstract string Serialize();
}