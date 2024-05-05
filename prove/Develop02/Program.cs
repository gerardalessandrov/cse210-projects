using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Journal my_journal = new Journal();
        my_journal.Run();


        string answer = "";


        while (answer != "5")
        {

            Console.WriteLine("Please select one of the following choices\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                my_journal.Writing();
            }
            if(answer=="2"){
                
            }
        }
    }
}