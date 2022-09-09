using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All numbers from 0 to 100");
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Next range of numbers from 1001 to 2500 with step -3");
            for (int k = 1001; k < 2501; k+=3)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Another statement form 100 to 0 with step -4");
            for (int i = 100; i >= 0; i-=4)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Last statement form 1 to 5 with step 0.2");
            for (double i = 1; i <= 5.1; i+=0.2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
