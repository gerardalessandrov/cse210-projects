
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List as many things as you can in the category: Things you are grateful for",
        "List as many things as you can in the category: People you admire",
        "List as many things as you can in the category: Activities you enjoy",
        "List as many things as you can in the category: Places you want to visit"
    };

    private int _count;

    public ListingActivity() : base("Listing", "This activity will help you focus by having you list items that fit a certain category.")
    {
    }

    protected override void Run()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        _count = 0;  // Initialize count

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                _count++;  // Increment count for each item entered
            }
            ShowSpinner(1);  // Simulate time for thinking and listing items
        }

        Console.WriteLine($"Time's up! You listed {_count} items.");
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}