using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            int obem = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());
            double obemLitri = obem * 0.001;
            double busySpace = double.Parse(Console.ReadLine()) * 0.01;



            Console.WriteLine(obemLitri * (1 - busySpace));
        }
    }
}