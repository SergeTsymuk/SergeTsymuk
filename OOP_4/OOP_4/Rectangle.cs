using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    internal class Rectangle
    {
        private double side1 = 0;
        private double side2 = 0;
        
        private double area = 0;
        private double perimeter = 0;

        public double Area { get; }
        public double Perimeter { get; }

        public Rectangle(double sideOne, double sideTwo)
        {
            side1 = sideOne;
            side2 = sideTwo;
        }

        public double AreaCalculator(double side1, double side2)
        {
            area = side1* side2;
            return area;
        }
        public double PerimeterCalculator(double side1, double side2)
        {
            perimeter =  2 * (side1 + side2);
            return perimeter;
        }
    }
}
