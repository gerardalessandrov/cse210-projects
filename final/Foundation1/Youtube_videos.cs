using System.Linq.Expressions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> entries;
    public override string ToString()
    {

        return $"The title of your video is{_title} with the author {_author} and the duration is of {_length}";


    }

    public void WriteNewEntry()
    {
        Console.WriteLine("Please enter the title of your video:");
        string _title = Console.ReadLine();
        Console.WriteLine("Please enter the author of your video:");
        string _author = Console.ReadLine();
        Console.WriteLine("Please enter the length of the video:");
        int _length = int.Parse(Console.ReadLine());


    }


    public class Comment
    {
        public string _name;
        public string _text;
        public List<string> comments;
        public Comment()
        {
            comments = new List<Comment>();
        }


        public void WriteyourComment()
        {
            Console.WriteLine("Please you can provide de comment about your video please");
            

        }

    }
}