using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    internal class Program
    {
        private static void Operation(int counter)
        {
            Operation(counter);
            Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
            Operation(0);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
