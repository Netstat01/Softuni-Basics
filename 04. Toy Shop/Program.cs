using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaEkskurzia = double.Parse(Console.ReadLine());
            int broiPuzeli = int.Parse(Console.ReadLine());
            int broiGovoreshtiKukli = int.Parse(Console.ReadLine());
            int broiPlusheniMecheta = int.Parse(Console.ReadLine());
            int broiMinioni = int.Parse(Console.ReadLine());
            int broiKamioncheta = int.Parse(Console.ReadLine());

            double pazel = 2.60;
            double govorqshtaKukla = 3;
            double plishenoMeche = 4.10;
            double minion = 8.20;
            double kamionche = 2;

            double vsichkoSuma = broiPuzeli * pazel + broiGovoreshtiKukli * govorqshtaKukla + broiPlusheniMecheta * plishenoMeche + broiMinioni * minion + broiKamioncheta * kamionche;
            int broiIgrachki = broiPuzeli + broiGovoreshtiKukli + broiPlusheniMecheta + broiMinioni + broiKamioncheta;

            if (broiIgrachki >= 50)
            {
                vsichkoSuma = vsichkoSuma - (vsichkoSuma * 0.25);
            }
            vsichkoSuma = vsichkoSuma - (vsichkoSuma * 0.1);
            if (vsichkoSuma >= cenaEkskurzia)
            {
                Console.WriteLine($"Yes! {(Math.Abs(vsichkoSuma - cenaEkskurzia)):f2} lv left.");
            }
            else if (vsichkoSuma < cenaEkskurzia)
            {
                Console.WriteLine($"Not enough money! {(Math.Abs(vsichkoSuma - cenaEkskurzia)):f2} lv needed.");
            }
        }
    }
}
