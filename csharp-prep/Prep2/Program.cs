using System;
//This is my Prep2
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage?");
        string name = Console.ReadLine();
        string letter = "";
        int percentage = int.Parse(name);
        if (percentage >= 90)
        {
            if (percentage % 10 >= 7)
            {
                letter = "+A";
                Console.WriteLine($"{letter}");
            }
            else if (percentage % 10 < 7)
            {
                letter = "-A";
                Console.WriteLine($"{letter}");
            }

        }
        else if (percentage >= 80)
        {
            if (percentage % 10 >= 7)
            {
                letter = "+B";
                Console.WriteLine($"{letter}");
            }
            else if (percentage % 10 < 7)
            {
                letter = "-B";
                Console.WriteLine($"{letter}");
            }

        }
        else if (percentage >= 70)
        {
            if (percentage % 10 >= 7)
            {
                letter = "+C";
                Console.WriteLine($"{letter}");
            }
            else if (percentage % 10 < 7)
            {
                letter = "-C";
                Console.WriteLine($"{letter}");
            }
        }
        else if (percentage >= 60)
        {
            if (percentage % 10 >= 7)
            {
                letter = "+D";
                Console.WriteLine($"{letter}");
            }
            else if (percentage % 10 < 7)
            {
                letter = "-D";
                Console.WriteLine($"{letter}");
            }
        }
        else
        {
            if (percentage % 10 >= 7)
            {
                letter = "+F";
                Console.WriteLine($"{letter}");
            }
            else if (percentage % 10 < 7)
            {
                letter = "-F";
                Console.WriteLine($"{letter}");
            }
        }
        if (percentage >= 70)
        {
            Console.WriteLine("You passed the course");
        }
        else if (percentage < 70)
        {
            Console.WriteLine("Sorry you dont passed the course you can try again the next period!!");
        }

    }
}