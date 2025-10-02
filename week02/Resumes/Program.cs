using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "software dev";
        job1._companyname = "microsoft";
        job1._startYear = 2025;
        job1._endYear = 2025;


        Job job2 = new Job();

        job2._companyname = "Apple";
        job2._jobTitle = "Head UI/UX designer";
        job2._startYear = 2018;
        job2._endYear = 2025;

        Resume newresume = new Resume();
        newresume._name = "Marvin";
        newresume.njobs.Add(job1);
        newresume.njobs.Add(job2);


        newresume.display();




        
    }
}




