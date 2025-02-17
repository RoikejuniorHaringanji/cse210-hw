// Eternal goal class
class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent(ref int score)
    {
        score += Points;
    }

    public override string GetStatus() => "[∞]";
    public override string Serialize() => $"Eternal:{Name},{Points}";
}
