using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            string b1 = Console.ReadLine();

            if (b1 == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }            
        }
    }
}
