using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statisti = int.Parse(Console.ReadLine());
            double cenaObleklo = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            if (statisti > 150)
            {
                cenaObleklo = (cenaObleklo - (cenaObleklo * 0.1)) * statisti;
                double obshto = cenaObleklo + decor;
                if (obshto > budget)
                {
                    double obshtoBudget = budget - obshto;
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {Math.Abs(obshtoBudget):f2} leva more.");
                }
                else
                {
                    double obshtoBudget = budget - obshto;
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {Math.Abs(obshtoBudget):f2} leva left.");
                }
            }
            else
            {
                cenaObleklo = cenaObleklo * statisti;
                double obshto = cenaObleklo + decor;


                if (obshto > budget)
                {
                    double obshtoBudget = budget - obshto;
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {Math.Abs(obshtoBudget):f2} leva more.");
                }
                else
                {
                    double obshtoBudget = budget - obshto;
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {Math.Abs(obshtoBudget):f2} leva left.");
                }
            }

        }
    }
}
