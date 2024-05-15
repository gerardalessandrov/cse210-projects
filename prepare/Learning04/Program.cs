using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment a1 = new Assignment("Gerard Vigo", "Communication");
        Console.WriteLine(a1.GetSummary());
        MathAssigment math_assigment = new MathAssigment("Fractions", "Gerard Vigo", "7.3", "12-13");
        Console.WriteLine(math_assigment.GetSummary());
        Console.WriteLine(math_assigment.GetHomeworkList());

        WritingAssignment writingAssigment = new WritingAssignment("Gerard Vigo", "European History", "The cause of the World War");
        Console.WriteLine(writingAssigment.GetSummary());
        Console.WriteLine(writingAssigment.GetWritingInformation());


    }
}