using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romb
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int row = int.Parse(a);

            for (int i = 1; i <= row; i++)

            {

                for (int j = 0; j < (row - i); j++)

                    Console.Write(" ");

                for (int j = 1; j <= i; j++)

                    Console.Write("*");

                for (int k = 1; k < i; k++)

                    Console.Write("*");

                Console.WriteLine();

            }



            for (int i = row - 1; i >= 1; i--)

            {

                for (int j = 0; j < (row - i); j++)

                    Console.Write(" ");

                for (int j = 1; j <= i; j++)

                    Console.Write("*");

                for (int k = 1; k < i; k++)

                    Console.Write("*");

                Console.WriteLine();

            }



            Console.WriteLine();
            Console.Read();

        }

    }
}

