class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        Video video2 = new Video("Object-Oriented Programming Basics", "Jane Smith", 400);
        Video video3 = new Video("Working with Collections in C#", "Alice Johnson", 250);


        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "Thanks for explaining!");
        video1.AddComment("User3", "Very helpful.");

        video2.AddComment("User4", "I learned a lot from this.");
        video2.AddComment("User5", "Can you make a video on inheritance?");
        video2.AddComment("User6", "Nice explanation!");

        video3.AddComment("User7", "Short and sweet!");
        video3.AddComment("User8", "I have a question.");


        List<Video> videos = new List<Video> { video1, video2, video3 };


        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}