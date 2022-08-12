using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {


            // while (true /*noshtuvki >= 0 && noshtuvki <= 200*/)
            // {
            string mesec = Console.ReadLine();
            int noshtuvki = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartamen = 0;





            if (mesec == "October" || mesec == "May")
            {
                studio = 50;
                apartamen = 65;

                if (noshtuvki > 14)
                {
                    studio = 50 - 50 * 0.30;
                    apartamen = 65 - 65 * 0.10;

                }
                else if (noshtuvki > 7)
                {
                    studio = 50 - 50 * 0.05;

                }
            }
            else if (mesec == "June" || mesec == "September")
            {
                studio = 75.20;
                apartamen = 68.70;

                if (noshtuvki > 14)
                {
                    studio = 75.20 - 75.20 * 0.20;
                    apartamen = 68.70 - 68.70 * 0.10;
                }
            }
            else if (mesec == "July" || mesec == "August")
            {
                studio = 76.00;
                apartamen = 77.00;

                if (noshtuvki > 14)
                {
                    apartamen = 77.00 - 77.00 * 0.10;
                }
            }


            Console.WriteLine($"Apartment: {(apartamen * noshtuvki):f2} lv.");
            Console.WriteLine($"Studio: {(studio * noshtuvki):f2} lv.");
            // }
        }
    }
}
