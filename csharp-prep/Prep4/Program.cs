using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int numero = -1;
        Console.WriteLine("Enter a list of numbers,type 0 when finished:");
        while (numero != 0)
        {

            Console.Write("Enter number(0 to quit):");
            string userResponse = Console.ReadLine();
            numero = int.Parse(userResponse);
            if (numero != 0)
            {

                numbers.Add(numero);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}
