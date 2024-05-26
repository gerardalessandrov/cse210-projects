public abstract class Goal
{
    protected string description;
    protected int value;
    protected bool isCompleted;

    public Goal(string description, int value)
    {

        this.description = description;
        this.value = value;
        isCompleted = false;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {

        string completionStatus = IsComplete() ? "[X]" : "[ ]";
        return $"{completionStatus} {description} - Points: {value}";
    }
    public abstract string GetStringRepresentation();
}
