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
            string number = Console.ReadLine();
            int number_1 = int.Parse(number);
            int a = number_1 / 100;
            int b = (number_1 - a * 100) / 10;
            int c = (number_1 - (a * 100 + b * 10));
            if (a > b && a > c && a != c && a!=b)
            {
                Console.WriteLine(a);
            }
           else if (b>a && b>c && a!=b && b != c)
            {
                Console.WriteLine(b);
            }
            else if (c>a && c>b && c!=a && c != b)
            {
                Console.WriteLine(c);
            }
            else if (a==b && b!=c && a!=c )
            {
                if (a > c)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(c);
                }

            }
            else if (b == c && a!=b && a!=c)
            {
                if (b > a)
                {
                    Console.WriteLine(b);
                   
                }
                else 
                {
                    Console.WriteLine(a);
                }
            }
            else if (a ==c && b!=c && a != b)
            {
                if (a > b)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
            else
            {
                Console.WriteLine("all digits are equal");
            }
          
            Console.Read();

           
        }
    }
}
