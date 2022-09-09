using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001
{
    internal class Program
    {
        private static void Operation(int counter)
        {
            counter--;
            Console.WriteLine("A: {0}", counter);

            if (counter != 0)
            {
                Operation(counter);
            }

            Console.WriteLine("B: {0}", counter);
        }
        static void Main(string[] args)
        {
            Operation(50);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
