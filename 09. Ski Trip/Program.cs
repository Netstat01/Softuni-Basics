using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int preestoi = int.Parse(Console.ReadLine());
            string pomeshtenie = Console.ReadLine();
            string ocenka = Console.ReadLine();

            double krainaCena = 0.00;
            int noshtuvka = preestoi - 1;

            switch (pomeshtenie)
            {
                case "room for one person":

                    krainaCena = noshtuvka * 18;

                    break;
                case "apartment":
                    if (preestoi < 10)
                    {
                        krainaCena = (noshtuvka * 25) - ((noshtuvka * 25) * 0.3);
                    }
                    else if (preestoi >= 10 && preestoi <= 15)
                    {
                        krainaCena = (noshtuvka * 25) - ((noshtuvka * 25) * 0.35);
                    }
                    else if (preestoi > 15)
                    {
                        krainaCena = (noshtuvka * 25) - ((noshtuvka * 25) * 0.5);
                    }
                    break;
                case "president apartment":
                    if (preestoi < 10)
                    {
                        krainaCena = (noshtuvka * 35) - ((noshtuvka * 35) * 0.1);
                    }
                    else if (preestoi >= 10 && preestoi <= 15)
                    {
                        krainaCena = (noshtuvka * 35) - ((noshtuvka * 35) * 0.15);
                    }
                    else if (preestoi > 15)
                    {
                        krainaCena = (noshtuvka * 35) - ((noshtuvka * 35) * 0.2);
                    }
                    break;
            }

            switch (ocenka)
            {
                case "positive":
                    krainaCena = krainaCena + (krainaCena * 0.25);
                    break;
                case "negative":
                    krainaCena = krainaCena - (krainaCena * 0.1);
                    break;
            }
            Console.WriteLine($"{krainaCena:f2}");
        }
    }
}
