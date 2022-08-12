using System;

namespace _01._Numbers_from_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            string sDuma = Console.ReadLine();
            int daljina = sDuma.Length;

            for (int i = 0; i < daljina; i++)
            {
                Console.WriteLine(sDuma[i]);
            }
        }
    }
}
