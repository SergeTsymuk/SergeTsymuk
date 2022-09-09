using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;



            int result = (x += y - x++ * z);
            int result2 = (z = --x - y * 5);
            int result3 = (y /= x + 5 % z);
            int result4 = (z = x++ + y * 5);
            int result5 = (x = y - x++ * z);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.ReadLine();
        }
    }
}
