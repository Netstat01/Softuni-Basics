using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());


            if (b1 <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (b1 > 10 & b1 <= 50)
            {
                Console.WriteLine("average");
            }
            else if (b1 > 50 & b1 <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (b1 > 150 & b1 <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }            
        }
    }
}
