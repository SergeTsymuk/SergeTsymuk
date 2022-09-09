using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Hello World");

            for (int i = 0; i < 15; i++)
            {
                Console.ForegroundColor++;
                Console.WriteLine("Hello World");
            }
            Console.ReadLine();
        }
    }
}
