using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int n = int.Parse(number);
            int S = 0;

            for (int i = 1; i <= n; i ++)
            {
                S += i;



            }
            Console.WriteLine(S);


            Console.Read();
        }
    }
}
