using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_zz_a
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
            if (a > b && a > c && a!=c)
            {
                if (b > c)
                {
                    Console.WriteLine(c + "," + b + "," +a);
                }
                else
                {
                    Console.WriteLine(b+ "," +c+ ","+a);
                }
            }
            else if (b > c)
            {
                if (a>c)
                { Console.WriteLine(c+ "," +a+ "," +b);
                }
                else
                {
                    Console.WriteLine(a + "," +c+ "," +b);
                }
            }
            else
            {
                if (a == b && a==c && b==c)
                {
                    Console.WriteLine("all numbers are equal");

                }
                else if  (a == c && b>c)
                {
                    Console.WriteLine(a+ "=" +c+ "<" + b);
                }
                else if (a == c && b < c)
                {
                    Console.WriteLine(a + "=" +b + "<" +c);
                }
                else if (b==c && a > c)
                {
                    Console.WriteLine(a+ "=" +b+ "<" +a);
                }
                else if (a>b)
                {
                    Console.WriteLine(b + "," +a+ "," +c);
                }
                else
                {
                    Console.WriteLine(a + "," +b+ "," +c);
                }
            }
         
            Console.Read();
        }
    }
}
