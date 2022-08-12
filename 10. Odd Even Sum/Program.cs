using System;

namespace _01._Numbers_from_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiPati = int.Parse(Console.ReadLine());
            int enevSum = 0;
            int oddSum = 0;


            for (int i = 1; i <= broiPati; i++)
            {
                if (i % 2 == 0)
                {
                    enevSum += int.Parse(Console.ReadLine());
                }
                else
                {
                    oddSum += int.Parse(Console.ReadLine());
                }
            }

            if (enevSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {enevSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(enevSum - oddSum)}");
            }
        }
    }
}
