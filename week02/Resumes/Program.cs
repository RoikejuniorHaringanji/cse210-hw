using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            _jobTitle = "Cyber Tech",
            _company = "UPDF",
            _startYear = 2019,
            _endYear = 2022
        };

        Job job2 = new Job
        {
            _jobTitle = "Cyber Tech",
            _company = "Beselfless",
            _startYear = 2022,
            _endYear = 2023
        };

        Resume myResume = new Resume
        {
            _personName = "Haringanji Roike"
        };
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}