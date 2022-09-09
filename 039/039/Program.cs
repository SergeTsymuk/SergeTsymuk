using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039
{
    internal class Program
    {
        public static void PrintResult(int one, int two, int three)
        {
            Console.WriteLine(one + two + three);
        }
        public static void PrintResult(double one, double two, double three)
        {
            Console.WriteLine(one - two - three);
        }
        public static void PrintResult(int one, int two)
        {
            int result = 0;
            for (int i = 0; i < two; i++)
            {
                result = one * one;
            }
                Console.WriteLine(result);
        }
        public static void PrintResult(int one, int two, int three, int sum = 0)
        {
            int result = one + two + three;
            Console.WriteLine($"{one} + {two} + {three} = {result}");
        }
        static void Main(string[] args)
        {
           PrintResult(1, 2, 3, 4);
           Console.ReadLine();
        }
    }
}
