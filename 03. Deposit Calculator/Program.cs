using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            double depozitSuma = double.Parse(Console.ReadLine());
            int depozitPeriod = int.Parse(Console.ReadLine());
            double godishenProcent = double.Parse(Console.ReadLine());

            Console.WriteLine(depozitSuma + depozitPeriod * (depozitSuma * (godishenProcent / 100)) / 12);
        }
    }
}