using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int i = 0;
           
            while(i<n)
            {
                i= i + 2;
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
