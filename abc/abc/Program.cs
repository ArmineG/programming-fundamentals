using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
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
            int abc = 100 * a1 + 10 * b1 + c1;
            Console.WriteLine(abc);
            if (abc<=999 && abc>=100)
            {


                if (a1 > b1 && a1 > c1)
                {
                    Console.WriteLine(a1);
                }
                else if (b1 > a1 && b1 > c1)
                {
                    Console.WriteLine(b1);
                }
                else
                {
                    Console.WriteLine(c1);
                }
            }
            else
            {
                Console.WriteLine("Your number must have 3 digits");
            }
            Console.Read();

           
        }
    }
}
