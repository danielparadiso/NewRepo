using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalcCircle
{
    class Circle
    {
        private double _area;
        private double _diameter;

        public Circle(double r)
        {
            Radius = r;
            CalcArea();
            CalcDiameter();
        }

        public Circle() : this(1)
        {
        }

        public double Radius { get; set; }

        public double Area
        {
            get { return _area; }                
            set { _area = value;
                CalcArea();}
        }

        public double Diameter
        {
            get { return _diameter; }
            set { _diameter = value;
                CalcDiameter(); }
        }

        public void Display()
        {
            Console.WriteLine("{0} is the Radius, {1} is the Area, {2} is the Diameter", Radius.ToString("0.00"), 
                Area.ToString("0.00"), Diameter.ToString("0.00"));
        }

        private void CalcArea()
        {
            _area = Math.PI*Radius * Radius;
        }

        private void CalcDiameter()
        {
            _diameter = Radius*2;
        }

    }
}
