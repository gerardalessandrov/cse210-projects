using System;
using System.Collections;
using System.Dynamic;
using System.IO;
using System.Net;
class entrada
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Entry { get; set; }
    public override string ToString()
    {
        return $"Fecha{Date.ToString("yyyy-MM-dd")} Prompt{Prompt}Entry{Entry}";
    }
}

class programa_Agenda
{
    private List<entrada> entries;
    public programa_Agenda()
    {
        entries = new List<entrada>();
    }
    public void WriteNewEntry()
    {
        string[] prompts ={
        "Te gusta comer",
        "Te gusta jugar",
        "Te gusta bailar",
        "Te gusta dormir?"
    };
        Random rand = new Random();
        string prompt_random = prompts[rand.Next(prompts.Length)];
        Console.WriteLine($"Prompt Random:{prompt_random}");
        Console.WriteLine($"Enter your response;");
        string response = Console.ReadLine();
        entrada myjournal = new entrada();
        myjournal.Date = DateTime.Now;
        myjournal.Prompt = prompt_random;
        myjournal.Entry = response;
        entries.Add(myjournal);

    }
    public void Presentaragenda()
    {
        foreach (var b in entries)
        {
            Console.WriteLine(b.ToString());

        }

    }

}
