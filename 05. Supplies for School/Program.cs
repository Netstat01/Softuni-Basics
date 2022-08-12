using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            double Himikali = double.Parse(Console.ReadLine());
            double Markeri = double.Parse(Console.ReadLine());
            double litriPreparat = double.Parse(Console.ReadLine());
            int namalenie = int.Parse(Console.ReadLine());

            Himikali = Himikali * 5.8;
            Markeri = Markeri * 7.2;
            litriPreparat = litriPreparat * 1.2;
            double cenaObshto = Himikali + Markeri + litriPreparat;


            Console.WriteLine(cenaObshto - (cenaObshto / 100) * namalenie);
        }
    }
}