using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = hour * 60 + minutes + 15;
            int calculatedMinutes = totalMinutes % 60;
            int calculatedHours = (totalMinutes - calculatedMinutes) / 60;


            if (calculatedHours < 24)
            {

                if (calculatedMinutes < 10)
                {
                    Console.WriteLine($"{calculatedHours}:0{calculatedMinutes}");
                }
                else
                {
                    Console.WriteLine($"{calculatedHours}:{calculatedMinutes}");
                }
            }
            else
            {
                calculatedHours = calculatedHours % 24;
                if (calculatedMinutes < 10)
                {
                    Console.WriteLine($"{calculatedHours}:0{calculatedMinutes}");
                }
                else
                {
                    Console.WriteLine($"{calculatedHours}:{calculatedMinutes}");
                }
            }

        }
    }
}
