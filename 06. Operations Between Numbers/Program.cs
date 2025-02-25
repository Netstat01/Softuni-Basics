﻿using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operato = Console.ReadLine();

            double result = 0;


            if (n2 != 0)
            {
                switch (operato)
                {
                    case "+":
                        result = n1 + n2;
                        if (result % 2 == 0)
                        {
                            Console.WriteLine($"{n1} + {n2} = {result} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{n1} + {n2} = {result} - odd");
                        }
                        break;
                    case "-":
                        result = n1 - n2;
                        if (result % 2 == 0)
                        {
                            Console.WriteLine($"{n1} - {n2} = {result} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{n1} - {n2} = {result} - odd");
                        }
                        break;
                    case "*":
                        result = n1 * n2;
                        if (result % 2 == 0)
                        {
                            Console.WriteLine($"{n1} * {n2} = {result} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{n1} * {n2} = {result} - odd");
                        }
                        break;
                    case "/":
                        result = (n1 * 1.00) / (n2 * 1.00);
                        Console.WriteLine($"{n1} / {n2} = {result:f2}");
                        break;
                    case "%":
                        result = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {result}");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }

        }
    }
}
