using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello  World!!");
        Person p1 = new Person();
        p1._name = "Gerard";
        p1._last_name = "Vigo";
        p1._age = 22;
        Person p2 = new Person();
        p2._name = "Elaine";
        p2._last_name = "Soto";
        p2._age = 20;
        List<Person> people = new List<Person>();
        people.Add(p1);
        people.Add(p2);
        foreach (Person p in people)
        {
            Console.WriteLine(p);
        }
        SaveToFile(people);
    }
    public static void SaveToFile(List<Person> people)
    {
        Console.WriteLine("Saving my file");
        string file_name = "people.txt";
        using (StreamWriter outputFile = new StreamWriter(file_name))
        {
            foreach (Person p in people)
            {
                outputFile.WriteLine($"{p._name}-{p._last_name}-{p._age}");
            }
        }

    }
}