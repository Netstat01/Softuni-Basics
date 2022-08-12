using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {

            double budgentPetar = double.Parse(Console.ReadLine());
            int broiVideoCarti = int.Parse(Console.ReadLine());
            int broiProcesori = int.Parse(Console.ReadLine());
            int broiRamPamet = int.Parse(Console.ReadLine());

            double videoCarti = 250 * broiVideoCarti;
            double procesor = broiProcesori * ((videoCarti / 100) * 35);
            double ramPamet = broiRamPamet * ((videoCarti / 100) * 10);

            double total = videoCarti + procesor + ramPamet;

            if (broiVideoCarti > broiProcesori)
            {
                total = total - ((total / 100) * 15);
                if (total > budgentPetar)
                {
                    budgentPetar = Math.Abs(budgentPetar - total);
                    Console.WriteLine($"Not enough money! You need {Math.Abs(budgentPetar):f2} leva more!");
                }
                else
                {
                    budgentPetar = Math.Abs(budgentPetar - total);
                    Console.WriteLine($"You have {Math.Abs(budgentPetar):f2} leva left!");
                }

            }
            else
            {
                if (total > budgentPetar)
                {
                    budgentPetar = Math.Abs(budgentPetar - total);
                    Console.WriteLine($"Not enough money! You need {Math.Abs(budgentPetar):f2} leva more!");
                }
                else
                {
                    budgentPetar = Math.Abs(budgentPetar - total);
                    Console.WriteLine($"You have {Math.Abs(budgentPetar):f2} leva left!");
                }
            }

        }
    }
}
