using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            double kvMetri = double.Parse(Console.ReadLine());
            double cenaMetri = kvMetri * 7.61;
            double procentOtstypka = (cenaMetri / 100) * 18;
            double krainaCena = cenaMetri - procentOtstypka;
            Console.WriteLine($"The final price is: {krainaCena} lv.");
            Console.WriteLine($"The discount is: {Math.Round(procentOtstypka, 3)} lv.");
        }
    }
}
