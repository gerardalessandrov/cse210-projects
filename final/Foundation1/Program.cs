using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Video v1 = new Video();

        Comentarios c1 = new Comentarios();
        bool done = false;
        while (!done)
        {
            Console.WriteLine("1.Please enter information about the video");
            Console.WriteLine("2.Display the informacion of the video");
            Console.WriteLine("3.Write a Comment about the video ");
            Console.WriteLine("4.Print  your Comments ");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Choose an option");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    v1.SetVideo();

                    break;
                case "2":
                    v1.DisplayVideo();
                    break;
                case "3":
                    c1.WriteaNewComment();
                    break;
                case "4":
                    c1.DisplayComment();
                    break;
                case "5":
                    done = true;
                    break;
                default:
                    Console.WriteLine("Invalid option.Please try again");
                    break;
            }

        }

    }
}