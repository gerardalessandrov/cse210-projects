using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Video v1 = new Video();
        v1.WriteNewEntry();
        Console.WriteLine(v1.ReturnString());

    }
}