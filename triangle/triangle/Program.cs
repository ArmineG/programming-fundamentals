using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int a1 = int.Parse(a);
            if (a1 > 3)
            {
                int count = 1;
                int count2 = 0;
                while (a1 != 0)
                {
                    a1 = a1 - 1;
                    count2 = count2 + 1;
                    count = count2;
                    Console.Write(" ");
                    while (count != 0) 
                    {
                        Console.Write("*");
                        count = count - 1;
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.Read();
        }

    }
}
