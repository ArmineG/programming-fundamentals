using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max
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
            int a1 = int.Parse(a);
            int b1 = int.Parse(b);
            int c1 = int.Parse(c);
            if (a1 > b1 && b1 > c1 )
            {if (a1 != b1 && a1 != c1 && b1 != c1)
                {
                    Console.WriteLine(c1);
                    Console.WriteLine(b1);
                    Console.WriteLine(a1);
                }
            else if (a1 =b1 && a1!= c1 && b1 != c1)
                {
                    Console.WriteLine(c1);
                    Console.WriteLine(b1);
                    Console.WriteLine(a1);
                }
            else if (a1 != b1 && a1 != c1 && b1 != c1)
                {

                }
               
                    
            }
            else if (b1 > a1 && a1 > c1 && a1 != b1 && a1 != c1 && b1 != c1)
            {
                Console.WriteLine(c1);
                Console.WriteLine(a1);
                Console.WriteLine(b1);
            }
            else if (a1 > c1 && c1 > b1 && a1 != b1 && a1 != c1 && b1 != c1)
            {
                Console.WriteLine(b1);
                Console.WriteLine(c1);
                Console.WriteLine(a1);
            }
            else if (c1 > a1 && a1 > b1 && a1 != b1 && a1 != c1 && b1 != c1)
            {
                Console.WriteLine(b1);
                Console.WriteLine(a1);
                Console.WriteLine(c1);
            }
            else if (c1 > b1 && b1 > a1 && a1 != b1 && a1 != c1 && b1 != c1)
            {
                Console.WriteLine(a1);
                Console.WriteLine(b1);
                Console.WriteLine(c1);
            }
            else if (b1 > c1 && c1 > a1 && a1 != b1 && a1 != c1 && b1 != c1)
            {
                Console.WriteLine(a1);
                Console.WriteLine(c1);
                Console.WriteLine(b1);
            }
            else
            {
                Console.WriteLine("all numbers are equal");
            }
            Console.Read();
        }
    }
}
