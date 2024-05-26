using System;

class Program
{
    static GoalManager goalManager = new GoalManager(); // Create a GoalManager instance
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        Console.WriteLine($"You have {goalManager.DisplayScore} points"); // Display current score
        bool quit = false;

        while (!quit)
        {
            // Display menu options
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu:");

            string choice = Console.ReadLine();

            // Perform actions based on user's choice
            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    goalManager.ListGoals();
                    break;
                case "3":
                    Console.WriteLine("Enter the filename to save goals:");
                    string saveFileName = Console.ReadLine();
                    goalManager.SaveGoals(saveFileName);
                    break;
                case "4":
                    Console.WriteLine("Enter the filename to load goals:");
                    string loadFileName = Console.ReadLine();
                    goalManager.LoadGoals(loadFileName);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();

                    break;
                case "5":
                    goalManager.RecordEvent(0);
                    break;
                case "6":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }


    static void CreateNewGoal()
    {
        Console.WriteLine("Enter goal description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter point value:");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("Select goal type (1. Simple Goal, 2. Eternal Goal, 3. Checklist Goal):");
        string typeChoice = Console.ReadLine();

        switch (typeChoice)
        {
            case "1":
                goalManager.AddGoal(new SimpleGoal(description, value));
                break;
            case "2":
                goalManager.AddGoal(new EternalGoal(description, value));
                break;
            case "3":
                Console.WriteLine("Enter required times:");
                int requiredTimes = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus value:");
                int bonusValue = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(description, value, requiredTimes, bonusValue));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}

