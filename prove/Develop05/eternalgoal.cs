public class EternalGoal : Goal
{
    public EternalGoal(string description, int value) : base(description, value)
    {
    }

    public override int RecordEvent()
    {
        return value;
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetDetailsString()
    {
        return $"{description} - Eternal";
    }

    public override string GetStringRepresentation()
    {
        return $"{description},{value},0"; // Eternal goals are always incomplete
    }
}