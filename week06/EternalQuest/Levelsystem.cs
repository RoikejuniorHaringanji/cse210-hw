// LevelSystem.cs
using System;
using System.IO;

public class LevelSystem
{
    public int Level { get; private set; } = 1;
    public int Score { get; private set; } = 0;
    private const int PointsPerLevel = 100;
    private const int BonusPoints = 10;
    private const string FileName = "level_data.txt";

    public void AddPoints(int points)
    {
        Score += points;
        CheckLevelUp();
    }

    private void CheckLevelUp()
    {
        while (Score >= Level * PointsPerLevel)
        {
            Level++;
            Score += BonusPoints;
            Console.WriteLine($"Level Up! You are now Level {Level}. Bonus {BonusPoints} points awarded!");
        }
    }

    public void SaveLevelData()
    {
        using (StreamWriter writer = new StreamWriter(FileName))
        {
            writer.WriteLine(Level);
            writer.WriteLine(Score);
        }
    }

    public void LoadLevelData()
    {
        if (File.Exists(FileName))
        {
            string[] data = File.ReadAllLines(FileName);
            Level = int.Parse(data[0]);
            Score = int.Parse(data[1]);
        }
    }

    public void DisplayLevelInfo()
    {
        Console.WriteLine($"Current Level: {Level}, Score: {Score}");
    }
}
