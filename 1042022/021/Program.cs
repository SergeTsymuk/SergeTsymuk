using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Value of the First side of rectangle");
            int firstSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Value of the Second side of rectangle");
            int secondtSide = Convert.ToInt32(Console.ReadLine());

            string enteredRequest = Console.ReadLine();

            if (enteredRequest == "square")
            {
                Console.WriteLine(firstSide * secondtSide);
            }
            else if (enteredRequest == "perimeter")
            {
                Console.WriteLine(firstSide * 2 + secondtSide * 2);
            }
            else
            {
                Console.WriteLine(" Please enter correct request");   
            }

            Console.ReadLine();

        }
    }
}
