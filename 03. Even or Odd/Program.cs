using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1 = (int.Parse(Console.ReadLine()) % 2);

            if (b1 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }            
        }
    }
}
