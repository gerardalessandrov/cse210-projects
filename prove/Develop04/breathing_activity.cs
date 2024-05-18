using System.ComponentModel;


public class BreathingActivity : Activity
{
   public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through slow breathing exercises.")
   {
   }

   protected override void Run()
   {
      DateTime endTime = DateTime.Now.AddSeconds(duration);
      Console.WriteLine("Get Ready...");
      while (DateTime.Now < endTime)
      {

         Console.WriteLine("Breathe in...");
         ShowCountDown(4);
         Console.WriteLine("Now breathe out...");
         ShowCountDown(2);

      }
   }
}

