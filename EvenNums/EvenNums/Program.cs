using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int a = 1;
            int j = 10;
            Console.WriteLine();
            Console.WriteLine("        Even Numbers");
            for (int i = 1; i <= 28; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            while (j <= 100)
            {
                for (x = a; x <= j; x++)
                {
                    if (x % 2 == 0)
                    {
                        Console.Write("{0, 5}", x);
                    }
                    a++;
                }
                Console.WriteLine();
                j += 10;
            }
            Console.ReadKey();
        }
    }
}
