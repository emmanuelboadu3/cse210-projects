using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // First job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2021;


        // Second job
        Job job2 = new Job();
        job2._jobTitle = "Product Designer";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Emmanuel Boadu";

        // Add jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Access and display the first job title
        Console.WriteLine(myResume._jobs[0]._jobTitle);



        myResume.Display(); 

    }
}