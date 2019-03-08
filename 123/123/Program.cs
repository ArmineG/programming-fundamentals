using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a..");
            string a = Console.ReadLine();
            Console.WriteLine("Input b..");
            string b = Console.ReadLine();
            Console.WriteLine("input c..");
            string c = Console.ReadLine();
            double a1 = double.Parse(a);
            double b1 = double.Parse(b);
            double c1 = double.Parse(c);
            if (a1<b1 && b1 < c1)
            {
                Console.WriteLine(a1);
                Console.WriteLine(b1);
                Console.WriteLine(c1);
            }
            else if (a1<c1 && c1 < b1)
            {
                Console.WriteLine(a1);
                Console.WriteLine(c1);
                Console.WriteLine(b1);
            }
            else if (b1>a1 && a1 > c1)
            {
                Console.WriteLine(c1);
                Console.WriteLine(a1);
                Console.WriteLine(b1);
            }
            else if (c1<b1 && b1<a1)
            {
                Console.WriteLine(c1);
                Console.WriteLine(b1);
                Console.WriteLine(a1);
            }
            else if (b1<a1 && a1 < c1)
            {
                Console.WriteLine(b1);
                Console.WriteLine(a1);
                Console.WriteLine(c1);
            }
            else
            {
                Console.WriteLine(b1);
                Console.WriteLine(c1);
                Console.WriteLine(a1);
            }
            Console.Read();
        }
    }
}
