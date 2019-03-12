using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int n = int.Parse(number);
            int i = 0;
            while (i < n)
            {
                i = i + 1 ;
                Console.WriteLine(i);
            }
          
            Console.Read();
        }
    }
}
