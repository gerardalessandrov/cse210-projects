using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start reflecting Activity");
            Console.WriteLine("2. Start breathing Activity");
            Console.WriteLine("3. Start listing Activity");
            Console.WriteLine("4. Start walking Activity");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Select a choice from the menu:");
            string choice = Console.ReadLine();

            if (choice == "5")
            {
                break;
            }

            Activity activity = choice switch
            {
                "1" => new ReflectingActivity(),
                "2" => new BreathingActivity(),
                "3" => new ListingActivity(),
                "4" => new WalkingActivity(),
                _ => null
            };

            if (activity != null)
            {
                activity.Start();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }
    }
}