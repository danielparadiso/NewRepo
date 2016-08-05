using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcCircle
{
    class TestCircle
    {
        static void Main(string[] args)
        {
            
            double smallRadius = 2.0;
            double largeRadius = 20.00;
            Circle circle1 = new Circle(smallRadius);
            Circle circle2 = new Circle(largeRadius);
            Circle circle3 = new Circle();

            circle1.Display();
            circle2.Display();
            circle3.Display();

            Console.ReadKey();


        }
    }
}
