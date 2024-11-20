﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for(int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"Factorial({number} = {factorial})");
        }
    }
}
