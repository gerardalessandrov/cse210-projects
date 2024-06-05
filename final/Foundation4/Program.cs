class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();


        activities.Add(new Running(new DateTime(2024, 06, 4), 30, 3.0)); 
        activities.Add(new Running(new DateTime(2024, 06, 4), 30, 4.8)); 
        activities.Add(new Cycling(new DateTime(2024, 06, 4), 45, 20)); 
        activities.Add(new Swimming(new DateTime(2024, 06, 4), 60, 10)); 

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}