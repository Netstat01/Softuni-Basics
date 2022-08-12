using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            string vidCvetq = Console.ReadLine();
            int broiCvetq = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());

            double cenaRoza = 5.00;
            double cenaDaliq = 3.80;
            double cenaLale = 2.80;
            double cenaNarcis = 3.00;
            double cenaGladiola = 2.50;
            double totalPrice = 0;

            switch (vidCvetq)
            {
                case "Roses":
                    totalPrice = broiCvetq * cenaRoza;
                    if (broiCvetq > 80)
                    {
                        totalPrice = totalPrice - ((totalPrice / 100) * 10);
                    }
                    break;
                case "Dahlias":
                    totalPrice = broiCvetq * cenaDaliq;
                    if (broiCvetq > 90)
                    {
                        totalPrice = totalPrice - ((totalPrice / 100) * 15);
                    }
                    break;
                case "Tulips":
                    totalPrice = broiCvetq * cenaLale;
                    if (broiCvetq > 80)
                    {
                        totalPrice = totalPrice - ((totalPrice / 100) * 15);
                    }
                    break;
                case "Narcissus":
                    totalPrice = broiCvetq * cenaNarcis;
                    if (broiCvetq < 120)
                    {
                        totalPrice = broiCvetq * (cenaNarcis + ((cenaNarcis / 100) * 15));
                    }

                    break;
                case "Gladiolus":
                    totalPrice = broiCvetq * cenaGladiola;
                    if (broiCvetq < 80)
                    {
                        totalPrice = broiCvetq * (cenaGladiola + ((cenaGladiola / 100) * 20));
                    }
                    break;
            }

            if (totalPrice <= budjet)
            {
                totalPrice = budjet - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {broiCvetq} {vidCvetq} and {totalPrice:f2} leva left.");
            }
            else
            {
                totalPrice = Math.Abs(budjet - totalPrice);
                Console.WriteLine($"Not enough money, you need {totalPrice:f2} leva more.");
            }

        }
    }
}
