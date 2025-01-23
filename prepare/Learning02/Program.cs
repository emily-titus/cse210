using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Strawberry Farms";
        job1._jobTitle = "Taste tester";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._company = "Yarn industries";
        job2._jobTitle = "Professional Yarn Gremlin";
        job2._startYear = 2022;
        job2._endYear = 2080;

        Resume resume1 = new Resume();
        resume1._name = "Emily Titus";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}