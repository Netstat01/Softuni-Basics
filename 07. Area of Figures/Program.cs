using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            string b1 = Console.ReadLine();


            if (b1 == "square")
            {
                double a1 = double.Parse(Console.ReadLine());
                a1 = a1 * a1;
                Console.WriteLine($"{a1:f3}");
            }
            else if (b1 == "rectangle")
            {
                double a1 = double.Parse(Console.ReadLine());
                double a2 = double.Parse(Console.ReadLine());
                a1 = a1 * a2;
                Console.WriteLine($"{a1:f3}");
            }
            else if (b1 == "circle")
            {
                double a1 = double.Parse(Console.ReadLine());
                a1 = a1 * a1 * Math.PI;
                Console.WriteLine($"{a1:f3}");
            }
            else if (b1 == "triangle")
            {
                double a1 = double.Parse(Console.ReadLine());
                double a2 = double.Parse(Console.ReadLine());
                a1 = (a1 * a2) / 2;
                Console.WriteLine($"{a1:f3}");
            }           
        }
    }
}
