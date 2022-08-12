using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            if (b1 > b2)
            {
                Console.WriteLine(b1);
            }
            else
            {
                Console.WriteLine(b2);
            }            
        }
    }
}