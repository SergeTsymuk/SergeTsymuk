using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01232022
{
    internal class Rectangle
    {
        public Rectangle(double s1, double s2) // constructor
        {
            side1 = s1;
            side2 = s2;
        }

        public double side1; // line 16-19 are fields
        public double side2;
        public double area;
        public double perimeter;
        
        public double AreaCalculator()
        {
            return area = side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return perimeter = (side1 + side2) * 2;
        }

        public double Area
        {
            get { return this.area;}
        }

        public double Perimeter
        {
            get { return this.perimeter; }
        }
    }
}
