using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01102022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = 1;
            int two = 2;
            int three = 3;

            int show = SumOfNumbers3(one, two, three, true);
            Console.WriteLine(show);
            Console.ReadLine();
        }

        static int SumOfNumbers(int a, int b, int c)
        {
            return a + b + c; 
        }

        static int SumOfNumbers2(ref int a, ref int b, ref int c)
        {
          return ++a + ++b + ++c; 
        }

        static int SumOfNumbers3(int a, int b, int c, bool y)
        {
            return y ? SumOfNumbers(a, b, c) : SumOfNumbers2(ref a, ref b, ref c);
        }
    }
}
