public class GoalManager
{
    private List<Goal> goals;
    private int score;

    public GoalManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            Goal goal = goals[index];
            score += goal.RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    public void ListGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
            writer.WriteLine($"Score: {score}");
        }
        Console.WriteLine("Goals and score saved successfully.");
    }

    public void LoadGoals(string filename)
    {
        goals.Clear();
        score = 0;
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("Score:"))
                {
                    score = int.Parse(line.Substring(7));
                }
                else
                {
                    string[] parts = line.Split(',');
                    string description = parts[0];
                    int value = int.Parse(parts[1]);
                    bool isCompleted = parts[2] == "1";
                    int timesCompleted = int.Parse(parts[3]);
                    if (timesCompleted > 0)
                    {
                        ChecklistGoal goal = new ChecklistGoal(description, value, timesCompleted, value);
                        goals.Add(goal);
                    }
                    else if (isCompleted)
                    {
                        SimpleGoal goal = new SimpleGoal(description, value);
                        goals.Add(goal);
                    }
                    else
                    {
                        EternalGoal goal = new EternalGoal(description, value);
                        goals.Add(goal);
                    }
                }
            }
        }
        Console.WriteLine("Goals and score loaded successfully.");
    }

}



