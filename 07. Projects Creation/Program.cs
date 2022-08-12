using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNameArchitect = Console.ReadLine();
            int numberProject = int.Parse(Console.ReadLine());
            int hoursProgects = numberProject * 3;
            Console.WriteLine($"The architect {firstNameArchitect} will need {hoursProgects} hours to complete {numberProject} project/s.");



        }
    }
}