using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {

            string imeSerial = Console.ReadLine();
            int vremeEpizod = int.Parse(Console.ReadLine());
            double prodaljitelnostPochivka = double.Parse(Console.ReadLine());

            double vremeObqd = prodaljitelnostPochivka / 8;
            double vremePochivka = prodaljitelnostPochivka / 4;
            prodaljitelnostPochivka = prodaljitelnostPochivka - (vremeObqd + vremePochivka);

            if (prodaljitelnostPochivka >= vremeEpizod)
            {
                prodaljitelnostPochivka = Math.Ceiling(Math.Abs(vremeEpizod - prodaljitelnostPochivka));
                Console.WriteLine($"You have enough time to watch {imeSerial} and left with {prodaljitelnostPochivka} minutes free time.");
            }
            else
            {
                prodaljitelnostPochivka = Math.Ceiling(Math.Abs(vremeEpizod - prodaljitelnostPochivka));
                Console.WriteLine($"You don't have enough time to watch {imeSerial}, you need {prodaljitelnostPochivka} more minutes.");
            }


        }
    }
}
