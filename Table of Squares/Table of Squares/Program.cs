using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("  Table of Squares");
            for (int i = 1; i <= 20; i++)
                Console.Write("-");
            Console.WriteLine();
            for (int i = 1; i <= 20; i++)
            {
                double sum;
                sum = Math.Pow(i, 2);
                Console.WriteLine("    {0} ^ 2 = {1}", i, sum);
            }
            Console.ReadKey();
        }
    }
}
