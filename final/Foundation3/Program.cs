class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");


        Event lecture = new Lecture("Lecture on AI", "Introduction to Artificial Intelligence", new DateTime(2024, 6, 10), new TimeSpan(14, 0, 0), address1, "John Doe", 50);
        Event reception = new Reception("Networking Reception", "Casual networking event", new DateTime(2024, 6, 15), new TimeSpan(18, 0, 0), address1, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Summer BBQ", "Annual company BBQ", new DateTime(2024, 7, 4), new TimeSpan(12, 0, 0), address1, "Sunny with a chance of rain");


        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("Reception:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}