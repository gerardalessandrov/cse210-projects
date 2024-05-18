using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    private string _name = "";
    private string _description = "";
    protected int duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        DisplayStartingMessage();
        duration = GetDurationFromUser();
        PrepareToBegin();
        Run();
        DisplayEndingMessage();
    }

    protected void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    
    protected abstract void Run();

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting the {_name} activity.");
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        ShowSpinner(3);
        Console.WriteLine($"You completed the {_name} activity for {duration} seconds.");
        ShowSpinner(3);
    }

    private int GetDurationFromUser()
    {
        Console.Write("How long, in seconds, would you like or your session?");
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.Write("Please enter a valid positive number for the duration: ");
        }
        return duration;
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        foreach (string s in animationString)
        {
            Console.Write(s);

            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        { 
            Console.Write($" {i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Done");
    }
}