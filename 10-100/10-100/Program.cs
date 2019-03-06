using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            string a = Console.ReadLine();
            double a1 = double.Parse(a);
            bool b = 10 <= a1;
            bool c = a1 <= 100;
            if (b)
            {
                if (c)
                {
                    Console.WriteLine("The number is in the range");
                }
                else
                {
                    Console.WriteLine("The number isn't in the range");
                }
            }

            else
            {
                Console.WriteLine("The number isn't in the range");
            }
            Console.ReadLine();
        }
    }
}
