using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1 = int.Parse(Console.ReadLine());


            if (b1 < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (b1 >= 100 & b1 <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (b1 > 200)
            {
                Console.WriteLine("Greater than 200");
            }            
        }
    }
}
