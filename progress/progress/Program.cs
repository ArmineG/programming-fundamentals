using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a..");
            string a = Console.ReadLine();
            Console.WriteLine("Input b..");
            string b = Console.ReadLine();
            Console.WriteLine("Input c..");
            string c = Console.ReadLine();

            double a1 = double.Parse(a);
            double b1 = double.Parse(b);
            double c1 = double.Parse(c);
            double d = b1 - a1;
            double k = b1 + d;
          
            if (c1 == k)
            {
                Console.WriteLine(true);
            }
            
            else
            {
                Console.WriteLine(false);
            }
            Console.Read();
        }
    }
}
