using System;
using System.Collections;
using System.IO;
class JournalEntry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Place { get; set; }
    public string Response { get; set; }
    public override string ToString()
    {
        return $"**Journal Entry**\n\n**Date:** {Date.ToString("yyyy-MM-dd")}\n\n**Place:** {Place}\n\n**Prompt:** \"{Prompt}\"\n\n**Response:** {Response}\n\n---\n";
    }
}
class JournalProgram
{
    private List<JournalEntry> entries;
    public JournalProgram()
    {
        entries = new List<JournalEntry>();
    }
    public void WriteNewEntry()
    {
        string[] prompts ={
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"};
        Random rand = new Random();
        string random_prompts = prompts[rand.Next(prompts.Length)];
        Console.WriteLine($"{random_prompts}");
        Console.WriteLine($"Response:");
        string response = Console.ReadLine();
        Console.Write("Place: ");
        string place = Console.ReadLine();
        JournalEntry entry = new JournalEntry();
        entry.Date = DateTime.Now;
        entry.Prompt = random_prompts;
        entry.Response = response;
        entry.Place = place;
        entries.Add(entry);

    }
    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }

    }
    public void SaveJournalToFile()
    {
        Console.WriteLine("Enter filename to save journal");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }
    public void LoadJournalFromFile()
    {
        Console.Write("Enter filename to load journal: ");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    JournalEntry entry = new JournalEntry();
                    entry.Date = DateTime.ParseExact(line.Split(": ")[1], "yyyy-MM-dd", null);
                    line = reader.ReadLine();
                    entry.Prompt = line.Split("\"")[1];
                    line = reader.ReadLine();
                    entry.Response = line.Split(": ")[1];
                    entries.Add(entry);

                }
            }
            Console.WriteLine("Journal loaded successfully!");

        }
        else
        {
            Console.WriteLine("File not found!");
        }

    }
};

