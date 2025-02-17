// Checklist goal class
class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override void RecordEvent(ref int score)
    {
        if (!IsCompleted)
        {
            CurrentCount++;
            score += Points;
            if (CurrentCount >= TargetCount)
            {
                score += BonusPoints;
                IsCompleted = true;
            }
        }
    }

    public override string GetStatus() => IsCompleted ? "[X]" : $"[{CurrentCount}/{TargetCount}]";
    public override string Serialize() => $"Checklist:{Name},{Points},{CurrentCount},{TargetCount},{BonusPoints},{IsCompleted}";
}