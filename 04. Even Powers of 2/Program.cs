using System;

namespace _01._Numbers_from_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int chislo = int.Parse(Console.ReadLine());
            for (int i = 0; i <= chislo; i += 2)
            {
                Console.WriteLine(num);
                num *= 4;
            }
        }
    }
}
