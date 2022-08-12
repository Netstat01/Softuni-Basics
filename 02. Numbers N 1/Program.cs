using System;

namespace _01._Numbers_from_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());
            for (int i = chislo; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
