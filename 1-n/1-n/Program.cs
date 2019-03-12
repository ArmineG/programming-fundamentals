using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_n
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int n = int.Parse(number);
            while (n > 1)
            {
                n = n-1;
                Console.WriteLine(n);

            }
            Console.Read();
        }
    }
}
