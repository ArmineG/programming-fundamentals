using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ax2
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


            if (a1 == 0)
            {
                if (b1 != 0 && c1 != 0)
                {
                    double x = (0 - c1) / b1;
                    Console.WriteLine(x);
                }
                else if (b1 != 0 && c1 == 0)
                {
                    double x = -b1;
                    Console.WriteLine(x);
                }
                else if (b1 == 0 && c1 != 0)
                {
                    double x = c1;
                    Console.WriteLine(x);
                }
                else
                {
                    double x = 0;
                    Console.WriteLine(x);
                }
            }
            else if (b1 == 0)
            {
                if (c1 < 0)
                {
                    double x = Math.Sqrt(-c1 / a1);
                    Console.WriteLine(x);
                }
                else if (c1 > 0)
                {
                    Console.WriteLine("No solution");
                }
            }
            else if (c1 == 0)
            {
                double x = (0 - b1) / a1;
                Console.WriteLine("2 solution");
                Console.WriteLine(0);
                Console.WriteLine(x);
            }

            else
            {
                double d = Math.Pow(b1, 2) - 4 * a1 * c1;

                if (d > 0)
                {
                    double x1 = (-b1 - Math.Sqrt(d)) / (2 * a1);

                    double x2 = (-b1 + Math.Sqrt(d)) / (2 * a1);

                    Console.WriteLine("2 solution");
                    Console.WriteLine(x1);
                    Console.WriteLine(x2);
                }
                else if (d == 0)
                {
                    double x = -b1 / (2 * a1);
                    Console.WriteLine("1 solution");
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine("No solution");
                }
            }







            Console.Read();
        }
    }
}
