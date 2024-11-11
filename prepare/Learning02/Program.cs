using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineering";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Console.WriteLine(job1._company);
        // job1.DisplayJobDetails();

        // Create a second Job
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;



        // Console.WriteLine(job2._company);
        // Display 
        // job2.DisplayJobDetails();


        // Step 7:Test your Resume class
        Resume myResume = new Resume();
        myResume._givenName = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Console.WriteLine($"{myResume._jobs[0]._jobTitle}");
        myResume.DisplayResumeDetails();

    }
}