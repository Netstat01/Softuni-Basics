using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int chasIzpit = int.Parse(Console.ReadLine());
            int minutaIzpit = int.Parse(Console.ReadLine());
            int chasPristigane = int.Parse(Console.ReadLine());
            int minutaPristigane = int.Parse(Console.ReadLine());

            int minutiIzpit = (chasIzpit * 60) + minutaIzpit;
            int minutiPristigane = (chasPristigane * 60) + minutaPristigane;

            int chasRazlika = (Math.Abs(minutiIzpit - minutiPristigane)) / 60;
            int minRazlika = (Math.Abs(minutiIzpit - minutiPristigane)) % 60;

            if (minutiIzpit - minutiPristigane <= 30 && minutiIzpit - minutiPristigane >= 0)
            {
                Console.WriteLine("On time");
                if (minRazlika > 0)
                {
                    Console.WriteLine($"{minRazlika} minutes before the start");
                }
            }
            else if (minutiIzpit - minutiPristigane > 30)
            {
                Console.WriteLine("Early");
                if (chasRazlika > 0)
                {
                    if (minRazlika > 9)
                    {
                        Console.WriteLine($"{chasRazlika}:{minRazlika} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{chasRazlika}:0{minRazlika} hours before the start");
                    }

                }
                else
                {
                    Console.WriteLine($"{minRazlika} minutes before the start");
                }
            }
            else if (minutiIzpit - minutiPristigane < 0)
            {
                Console.WriteLine("Late");
                if (chasRazlika > 0)
                {
                    if (minRazlika > 9)
                    {
                        Console.WriteLine($"{chasRazlika}:{minRazlika} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{chasRazlika}:0{minRazlika} hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{minRazlika} minutes after the start");
                }
            }

        }
    }
}
