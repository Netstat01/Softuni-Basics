using System;

namespace SoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");



            int gradusi = int.Parse(Console.ReadLine());
            string denonoshtie = Console.ReadLine();

            string outfit = "";
            string Shoes = "";


            if (denonoshtie == "Morning")
            {
                if ((10 <= gradusi) && (gradusi <= 18))
                {
                    outfit = "Sweatshirt";
                    Shoes = "Sneakers";
                }
                else if ((18 <= gradusi) && (gradusi <= 24))
                {
                    outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (gradusi >= 25)
                {
                    outfit = "T-Shirt";
                    Shoes = "Sandals";
                }
            }

            else if (denonoshtie == "Afternoon")
            {
                if ((10 <= gradusi) && (gradusi <= 18))
                {
                    outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if ((18 <= gradusi) && (gradusi <= 24))
                {
                    outfit = "T-Shirt";
                    Shoes = "Sandals";
                }
                else if (gradusi >= 25)
                {
                    outfit = "Swim Suit";
                    Shoes = "Barefoot";
                }
            }

            else if (denonoshtie == "Evening")
            {
                if ((10 <= gradusi) && (gradusi <= 18))
                {
                    outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if ((18 <= gradusi) && (gradusi <= 24))
                {
                    outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (gradusi >= 25)
                {
                    outfit = "Shirt";
                    Shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {gradusi} degrees, get your {outfit} and {Shoes}.");
        }
    }
}
