using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            int straniciKniga = int.Parse(Console.ReadLine());
            int straniciZaChas = int.Parse(Console.ReadLine());
            int den = int.Parse(Console.ReadLine());

            Console.WriteLine((straniciKniga / straniciZaChas) / den);
        }
    }
}