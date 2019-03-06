using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3d_7d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            string a = Console.ReadLine();

            int a1 = int.Parse(a);


            int value = a1 % 7;
            if (a1 != 0)
            {


                if (value == 0)
                {
                    int x = a1 / 7;
                    Console.WriteLine(x);
                    Console.WriteLine("The number can be divided by 7");
                }
                else
                {
                    Console.WriteLine("The number can't be divided by 7");
                }
                int value1 = a1 % 3;
                if (value == 0)
                {
                    int x = a1 / 3;
                    Console.WriteLine(x);
                    Console.WriteLine("The number can be divided by 3");
                }
                else
                {
                    Console.WriteLine("The number can't be divided by 3");
                }
            }
            else
            {
                Console.WriteLine("0");
            }


            Console.ReadLine();
        }
    }
}
