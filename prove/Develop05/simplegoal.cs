public class SimpleGoal : Goal
{
    public SimpleGoal(string description, int value) : base(description, value)
    {
    }

    public override int RecordEvent()
    {
        isCompleted = true;
        return value;
    }

    public override bool IsComplete()
    {
        return isCompleted;
    }

    public override string GetDetailsString()
    {
        return $"{description} - {(isCompleted ? "Completed" : "Incomplete")}";
    }

    public override string GetStringRepresentation()
    {
        return $"{description},{value},{(isCompleted ? "1" : "0")}";
    }
}