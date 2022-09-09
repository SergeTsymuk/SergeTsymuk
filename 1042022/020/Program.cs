using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Number:");
            int sideOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number:");
            int sideTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Third Number:");
            int sideThree = Convert.ToInt32(Console.ReadLine());


            if (sideOne + sideTwo <= sideThree || sideTwo + sideThree <= sideOne || sideOne + sideThree <= sideTwo)
            {
                Console.WriteLine("Triangle with theese parameters not exist");
            }
            else if (sideOne == sideTwo && sideTwo == sideThree)
            {
                Console.WriteLine("equilateral triangle");
            }
            else if (sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree)
            {
                Console.WriteLine("triangle has equal sides");
            }
            else if (sideOne * 2 + sideTwo * 2 == sideThree * 2 || 
                sideThree * 2 + sideTwo * 2 == sideOne * 2 || 
                sideOne * 2 + sideThree * 2 == sideTwo * 2)
            {
                Console.WriteLine("Triangle is rectangular");
            }
            else
            {
                Console.WriteLine("No tiangle exist with this parameters");
            }
            Console.ReadLine();
            
            
               
        }
    }
}
