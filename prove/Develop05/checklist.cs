public class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int requiredTimes;
    private int bonusValue;

    public ChecklistGoal(string description, int value, int requiredTimes, int bonusValue) : base(description, value)
    {
        this.requiredTimes = requiredTimes;
        this.bonusValue = bonusValue;
        timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        timesCompleted++;
        isCompleted = timesCompleted >= requiredTimes;
        int totalValue = value + (isCompleted ? bonusValue : 0);
        return totalValue;
    }

    public override bool IsComplete()
    {
        return isCompleted;
    }

    public override string GetDetailsString()
    {
        return $"{description} - Completed {timesCompleted}/{requiredTimes} times";
    }

    public override string GetStringRepresentation()
    {
        return $"{description},{value},{(isCompleted ? "1" : "0")},{timesCompleted}";
    }
}
