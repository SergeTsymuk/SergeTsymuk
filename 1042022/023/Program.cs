using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first integer number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second integer number");
            int y = Convert.ToInt32(Console.ReadLine());

            int xA = ((x % 2) == 0) ? x : ++x;
            int yA = ((y % 2) == 0) ? y : ++y;

            string result = (((xA + yA) % 4) == 0) ? 
                $"Sum of '{xA}' and '{yA}' could be devided by: 4" : 
                $"Sum of '{xA}' and '{yA}' couldn't be devided by: 4";

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
