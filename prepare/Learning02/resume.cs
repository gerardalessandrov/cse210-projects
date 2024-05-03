using System.Security.Cryptography.X509Certificates;


public class Resume
{
    public string _personname = "";
    public List<Job> resume = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_personname}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in resume)
        {
            // This calls the Display method on each job
            job.DisplayJobDetails();
        }
    }
}
