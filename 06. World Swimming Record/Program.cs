using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {

            double recordSecundi = double.Parse(Console.ReadLine());
            double razstoqnieMetri = double.Parse(Console.ReadLine());
            double secundaMetar = double.Parse(Console.ReadLine());

            //  съпротивлението на водата го забавя на всеки 15 м. с 12.5 секунди
            //  резултатът трябва да се закръгли надолу до най-близкото цяло число.
            //  Да се изчисли времето в секунди, за което Иванчо ще преплува разстоянието и разликата спрямо Световния рекорд

            double vremeRazstoqnie = razstoqnieMetri * secundaMetar;
            double vremeZabavqne = Math.Floor(razstoqnieMetri / 15) * 12.5;
            vremeRazstoqnie = vremeRazstoqnie + vremeZabavqne;

            double razlika = Math.Abs(recordSecundi - vremeRazstoqnie);

            if (vremeRazstoqnie < recordSecundi)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {vremeRazstoqnie:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {razlika:f2} seconds slower.");
            }
        }
    }
}
