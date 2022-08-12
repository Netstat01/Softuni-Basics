using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            double godishnaTaksa = double.Parse(Console.ReadLine());

            double priceKecove = godishnaTaksa - (godishnaTaksa / 100) * 40;
            double priceEquitment = priceKecove - (priceKecove / 100) * 20;
            double priceBall = priceEquitment / 4;
            double priceAccesoires = priceBall / 5;

            double finalPrice = godishnaTaksa + priceKecove + priceEquitment + priceBall + priceAccesoires;


            Console.WriteLine(Math.Round(finalPrice, 3));
        }
    }
}