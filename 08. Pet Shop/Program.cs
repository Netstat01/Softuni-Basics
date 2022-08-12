using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            int hranaKucheta = int.Parse(Console.ReadLine());
            int hranaKotki = int.Parse(Console.ReadLine());
            double cenakucheta = hranaKucheta * 2.5;
            double cenakotki = hranaKotki * 4;
            double obshto = cenakucheta + cenakotki;
            Console.WriteLine($"{obshto} lv.");
        }
    }
}