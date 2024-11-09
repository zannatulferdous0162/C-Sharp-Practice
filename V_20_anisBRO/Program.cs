using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_20_anisBRO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1,number2, number3,sum;
            double average;
            Console.Write("number1 = ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("number2 = ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("number3 = ");
            number3 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2 + number3;
            Console.WriteLine($"sum = {sum}");

            average = (double)sum / 3;
            Console.WriteLine($"average = {average}");


        }
    }
}
