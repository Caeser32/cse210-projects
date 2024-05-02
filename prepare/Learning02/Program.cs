using System;

class Program
{
    static void Main()
    {

        Job job1 = new Job();
        job1._company = "Oishi";
        job1._jobTitle = "Delivery driver";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "BYU-Pathway";
        job2._jobTitle = "Peer-advisor";
        job2._startYear = 2023;
        job2._endYear = 2026;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();


        Resume myResume = new Resume();
        myResume._personName = "Tumisang Msiza";


        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
