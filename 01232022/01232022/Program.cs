using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01232022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter size of the side1.");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter size of the side2.");
            double side2 = Convert.ToDouble(Console.ReadLine());
            var rectang = new Rectangle(side1, side2);

            double area = rectang.AreaCalculator();
            double perimeter = rectang.PerimeterCalculator();
            Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");
            Console.WriteLine($"The area of the ractangele is: {area}");
            Console.ReadLine();
            
            
            
            
            
            //var person1 = new Person("Mike", 25);
            //person1.PrintToConsole();
            //var person2 = new Person("Stive", 40);
            //person2.PrintToConsole();
            //var person3 = new Person();
            //person3.PrintToConsole();
            //Console.ReadLine();
        }
    }
}
