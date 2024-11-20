using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table_from_m_to_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber, endNumber;
            Console.Write("Enter startNumber number : ");
            startNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter endNumber number : ");
            endNumber = Convert.ToInt32(Console.ReadLine());

            for(int i = startNumber; i <= endNumber; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                }
                Console.WriteLine("  ");
            }
        }
    }
}
