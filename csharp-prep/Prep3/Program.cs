using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 101);
        int guess = -1;
        while (guess != magicnumber)
        {
            Console.Write("What is your guess:");
            guess = int.Parse(Console.ReadLine());
            if (magicnumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicnumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }
        }
    }
}
