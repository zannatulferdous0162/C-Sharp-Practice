using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature converted started");
            Console.WriteLine("Choose 1 : Fahrenheit to celsisus");
            Console.WriteLine("Choose 2 : Celsisus to Fahrenheit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Enter Fahrenheit temparature :");
                        double fahrenheit = Convert.ToDouble(Console.ReadLine());
                        double celsisus = (fahrenheit - 32) / 1.8;
                        Console.Write($"Temparature in  celsisus: {celsisus:F2} ");
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter Celsisus temparature :");
                        double cels = Convert.ToDouble(Console.ReadLine());
                       
                        double fahren = cels * 1.8 + 32;
                        Console.Write($"Temparature in  celsisus: {fahren:F2} ");
                        break;
                    }
                   
                default:
                    break;
            }
        }
    }
}
