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
            int abc = 100 * a1 + 10 * b1 + c1;
            

        }
    }
}
