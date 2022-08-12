using System;

namespace SoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5.00;
            double income = 0.0;

            string tipPojekciq = Console.ReadLine();
            int red = int.Parse(Console.ReadLine());
            int kolona = int.Parse(Console.ReadLine());

            if (tipPojekciq == "Premiere")
            {
                income = red * kolona * premiere;
            }

            else if (tipPojekciq == "Normal")
            {
                income = red * kolona * normal;
            }

            else if (tipPojekciq == "Discount")
            {
                income = (1.00 * red * kolona) * discount;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
