public class WalkingActivity : Activity
{
    public WalkingActivity() : base("Walking", "This activity will help you relax by guiding you through walking exercises.")
    {
    }

    protected override void Run()
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Console.WriteLine("Get Ready...");
        while (DateTime.Now < endTime)
        {

            Console.WriteLine("Get up, breathe and walk a few steps forward....");
            ShowCountDown(10);
            Console.WriteLine("breathe and return to the place where you were...");
            ShowCountDown(10);

        }
    }
}