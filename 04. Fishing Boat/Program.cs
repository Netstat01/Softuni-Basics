using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            int broiRibari = int.Parse(Console.ReadLine());


            int cenaProlet = 3000;
            int cenaLqtoEsenq = 4200;
            int cenaZima = 2600;
            double totalPrice = 0;


            switch (sezon)
            {
                case "Spring":
                    if (broiRibari <= 6)
                    {
                        totalPrice = cenaProlet - ((cenaProlet / 100) * 10);
                    }
                    else if (broiRibari >= 7 && broiRibari <= 11)
                    {
                        totalPrice = cenaProlet - ((cenaProlet / 100) * 15);
                    }
                    else if (broiRibari > 12)
                    {
                        totalPrice = cenaProlet - ((cenaProlet / 100) * 25);
                    }
                    break;
                case "Summer":

                    if (broiRibari <= 6)
                    {
                        totalPrice = cenaLqtoEsenq - ((cenaLqtoEsenq / 100) * 10);
                    }
                    else if (broiRibari >= 7 && broiRibari <= 11)
                    {
                        totalPrice = cenaLqtoEsenq - ((cenaLqtoEsenq / 100) * 15);
                    }
                    else if (broiRibari > 12)
                    {
                        totalPrice = cenaLqtoEsenq - ((cenaLqtoEsenq / 100) * 25);
                    }
                    break;
                case "Autumn":
                    if (broiRibari <= 6)
                    {
                        totalPrice = cenaLqtoEsenq - ((cenaLqtoEsenq / 100) * 10);
                    }
                    else if (broiRibari >= 7 && broiRibari <= 11)
                    {
                        totalPrice = cenaLqtoEsenq - ((cenaLqtoEsenq / 100) * 15);
                    }
                    else if (broiRibari > 12)
                    {
                        totalPrice = cenaLqtoEsenq - ((cenaLqtoEsenq / 100) * 25);
                    }
                    break;
                case "Winter":
                    if (broiRibari <= 6)
                    {
                        totalPrice = cenaZima - ((cenaZima / 100) * 10);
                    }
                    else if (broiRibari >= 7 && broiRibari <= 11)
                    {
                        totalPrice = cenaZima - ((cenaZima / 100) * 15);
                    }
                    else if (broiRibari > 12)
                    {
                        totalPrice = cenaZima - ((cenaZima / 100) * 25);
                    }
                    break;
            }

            if (broiRibari % 2 == 0 && !(sezon == "Autumn"))
            {
                totalPrice = totalPrice - (totalPrice / 100) * 5;
                if (budjet >= totalPrice)
                {
                    Console.WriteLine($"Yes! You have {Math.Abs(budjet - totalPrice):f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {Math.Abs(budjet - totalPrice):f2} leva.");
                }
            }
            else
            {
                if (budjet >= totalPrice)
                {
                    Console.WriteLine($"Yes! You have {Math.Abs(budjet - totalPrice):f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {Math.Abs(budjet - totalPrice):f2} leva.");
                }
            }

        }
    }
}
