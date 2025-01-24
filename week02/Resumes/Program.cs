using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            _jobTitle = "wholesaler",
            _company = "Kiyembe",
            _startYear = 2020,
            _endYear = 2022
        };

        Job job2 = new Job
        {
            _jobTitle = "Software engineer",
            _company = "Vistoral Technologies",
            _startYear = 2021,
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