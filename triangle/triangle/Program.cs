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
            int row = int.Parse(a);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row - i; j++)
                {
                    Console.Write(" ");

                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }

    }
}
