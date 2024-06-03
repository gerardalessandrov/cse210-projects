using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System;
using System.Collections;
using System.IO;

class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; }
    public List<Video> videos;
    public Video()
    {
        videos = new List<Video>();

    }
    public void SetVideo()
    {
        Video video = new Video();
        Console.WriteLine("Please enter the title of your video:");
        string title = Console.ReadLine();
        Console.WriteLine("Please enter the author of your video:");
        string author = Console.ReadLine();
        Console.WriteLine("Please enter the length of the video(in seconds ):");
        int length = int.Parse(Console.ReadLine());

        video._title = title;
        video._author = author;
        video._length = length;
        videos.Add(video);
    }
    public string DisplayVideoInformation()
    {
        return $"The title is {_title} and the author of the video is {_author} and lasts {_length} seconds.";

    }
    public void DisplayVideo()
    {
        foreach (var video in videos)
        {
            Console.WriteLine(video.DisplayVideoInformation());
        }

    }

}
class Comentarios
{

    public string _name { get; set; }
    public string _comment { get; set; }
    public int _count;
    public List<Comentarios> comments;
    public Comentarios()
    {
        comments = new List<Comentarios>();
    }
    public void WriteaNewComment()
    {



        Comentarios comment1 = new Comentarios();
        Console.WriteLine("Please enter your name");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter your comment");
        string commentario = Console.ReadLine();



        comment1._comment = commentario;
        comment1._name = name;
        comments.Add(comment1);

    }
    public void DisplayComment()
    {
        _count = 0;
        foreach (var comment1 in comments)
        {
            _count++;
            Console.WriteLine($"{_count}-{comment1.ToString()}this comment was made by{_name}");

        }



    }




    public override string ToString()

    {


        return $"{_comment}";

    }

}



