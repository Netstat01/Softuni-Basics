using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            double BGN = (USD * 180) / Math.PI;

            Console.WriteLine(BGN);
        }
    }
}
