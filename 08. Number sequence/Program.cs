using System;

namespace _01._Numbers_from_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int broiCisla = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;


            for (int i = 0; i < broiCisla; i++)
            {
                suma = int.Parse(Console.ReadLine());
                if (suma > maxNum)
                {
                    maxNum = suma;
                }
                if (suma < minNum)
                {
                    minNum = suma;
                }
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
