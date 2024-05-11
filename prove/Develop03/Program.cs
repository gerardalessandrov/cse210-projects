using System;
using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Net.Quic;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        string[] phrases ={ "It's simple: just make it happen.",
           "Nothing belongs to us except memories.",
            "Go to the world",
            "The worst experience is the best teacher.",
            "Never doubt yourself",

        "When everything seems to be going against you, remember that the plane takes off against the wind."};
        Random rand = new Random();
        string random_phrase = phrases[rand.Next(phrases.Length)];
        Scripture scripture = new Scripture(reference, scriptureText);


        while (!scripture.isCompletelyHidden())
        {

            Console.Clear();

            scripture.HideRandomWords(3);

            Console.Write(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine($" Motivational phrase {random_phrase}");



            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                return;
            }
        }

        Console.WriteLine("All words are hidden. Press Enter to exit.");
        Console.ReadLine();
    }
}