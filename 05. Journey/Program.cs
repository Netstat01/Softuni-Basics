using System;

namespace Jornay
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string typeRest = "";
            double totalCost = 0;

            if (season == "summer")
            {
                typeRest = "Camp";
                if (budget <= 100)
                {
                    totalCost = (budget / 100) * 30;
                    destination = "Bulgaria";
                    typeRest = "Camp";
                }
                else if (budget <= 1000)
                {
                    totalCost = (budget / 100) * 40;
                    destination = "Balkans";
                    typeRest = "Camp";
                }
                else if (budget >= 1000)
                {
                    totalCost = (budget / 100) * 90;
                    destination = "Europe";
                    typeRest = "Hotel";
                }
            }
            else if (season == "winter")
            {
                if (budget <= 100)
                {
                    totalCost = (budget / 100) * 70;
                    destination = "Bulgaria";
                    typeRest = "Hotel";
                }
                else if (budget <= 1000)
                {
                    totalCost = (budget / 100) * 80;
                    destination = "Balkans";
                    typeRest = "Hotel";
                }
                else if (budget >= 1000)
                {
                    totalCost = (budget / 100) * 90;
                    destination = "Europe";
                    typeRest = "Hotel";
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeRest} - {totalCost:f2}");
        }
    }
}
