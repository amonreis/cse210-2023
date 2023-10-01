using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Foreign Language Teacher";
        job1._company = "Alianca America";
        job1._startYear = 2021;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Trilingual Instructor/Interpreter";
        job2._company = "Brazil MTC";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Amon Reis";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        myResume.DisplayResumeDetails();

    }
}