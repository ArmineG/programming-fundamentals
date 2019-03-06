using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a..");
            string a = Console.ReadLine();
            Console.WriteLine("Input b..");
            string b = Console.ReadLine();

            double a1 = double.Parse(a);
            double b1 = double.Parse(b);
            if (a1 == b1)
            {
                double x = a1 = b1;
                double z = x * x * x;
                Console.WriteLine(z);


            }
            else
            {
                double x = a1 + b1;
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }
    }
}
