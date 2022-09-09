using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003
{
    internal class Program
    {
        public static int Operation(int factorial)
        {
            if (factorial == 1)
            {
                return 1; 
            }
            else
            {
                return factorial * Operation(factorial - 1);
            }
        }
        static void Main(string[] args)
        {
            int ret = Operation(5);
            Console.WriteLine($" Factorial = {ret}");
            Console.ReadLine();
        }
    }
}
