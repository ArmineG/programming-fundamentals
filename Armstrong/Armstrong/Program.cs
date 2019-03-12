using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
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
            int number_2 = a * a *a + b * b * b + c * c * c;
            bool n = number_2 == number_1;
           if (n)
            {
                Console.WriteLine(number_1);
            }

            else
            {
                Console.WriteLine("The number isn't Armstrong number");
            }


            Console.Read();
        }
    }
}
