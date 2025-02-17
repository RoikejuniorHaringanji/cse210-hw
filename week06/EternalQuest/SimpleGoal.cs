// Simple goal class
class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent(ref int score)
    {
        if (!IsCompleted)
        {
            score += Points;
            IsCompleted = true;
        }
    }

    public override string GetStatus() => IsCompleted ? "[X]" : "[ ]";
    public override string Serialize() => $"Simple:{Name},{Points},{IsCompleted}";
}