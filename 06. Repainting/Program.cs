using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            double nailon = double.Parse(Console.ReadLine());
            double boya = double.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int chasove = int.Parse(Console.ReadLine());

            nailon = (nailon + 2) * 1.5;
            boya = (boya + (boya / 100) * 10) * 14.5;
            razreditel = razreditel * 5;

            double obshtoSuma = nailon + boya + razreditel + 0.40;
            double sumaMaistori = ((nailon + boya + razreditel + 0.40) * 0.3) * chasove;


            Console.WriteLine(obshtoSuma + sumaMaistori);
        }
    }
}