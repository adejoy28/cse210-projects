public class Resume()
{
    public string _givenName;
    public List<Job> _jobs = new List<Job>();

    // Display Method
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_givenName}");
        Console.WriteLine("Jobs");
        foreach (Job jobDetails in _jobs)
        {
            jobDetails.DisplayJobDetails();
        }
    }
}