using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2019;
        job1._endYear = 2024;
        Job job2 = new Job();
        job2._jobTitle = "Microsoft";
        job2._company = "Apple";
        job2._startYear = 2020;
        job2._endYear = 2023;
        Resume resume = new Resume();
        resume.resume.Add(job1);
        resume.resume.Add(job2);
        resume._personname = "Allison Rose";
        resume.Display();

    }

}