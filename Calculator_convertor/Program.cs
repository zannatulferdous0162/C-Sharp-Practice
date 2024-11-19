using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_convertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            char operation;

            Console.Write("Enter an operation (+,-,*,/) :");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter an number1 input");
            number1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter an number2 input");
            number2 = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    {
                        Console.WriteLine($"{number1} + {number2} = {number1 + number2} ");
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine($"{number1} - {number2} = {number1 - number2} ");
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine($"{number1} * {number2} = {number1 * number2} ");
                        break;
                    }
                case '/':
                    {
                        if (number2 != 0)
                        {
                            Console.WriteLine($"{number1} / {number2} = {number1 / number2} ");
   
                        }
                        else
                        {
                            Console.WriteLine("Can not divided by ZERO");
                        }
                        break;
                    }
                   
                default:
                        Console.WriteLine("Invalid");
                        break;
                    
            }

        }
    }
}
