using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
       
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Technician";
        job2._company = "GO-HRE";
        job2._startYear = 2019;
        job2._endYear = 2020;

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume._name = "George Appau-Nkansah";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayJobDetails();
    }
}