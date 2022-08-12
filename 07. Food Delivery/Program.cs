using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            double menuChicken = double.Parse(Console.ReadLine());
            double menuFish = double.Parse(Console.ReadLine());
            double menuVegetarian = double.Parse(Console.ReadLine());

            menuChicken = menuChicken * 10.35;
            menuFish = menuFish * 12.4;
            menuVegetarian = menuVegetarian * 8.15;

            double allPriceMenu = menuChicken + menuFish + menuVegetarian;
            double priceDesert = (allPriceMenu / 100) * 20;

            double finalPrice = allPriceMenu + priceDesert + 2.5;

            Console.WriteLine(finalPrice);
        }
    }
}