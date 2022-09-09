using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter First Word");
            string s1 = Console.ReadLine();
            Console.WriteLine("Please enter Second Word");
            string s2 = Console.ReadLine();

            var builder = new StringBuilder();
            for (int i = 0; i < s1.Length; i++)
            {
                builder.Append(s1[i]);
                builder.Append(s2[i]);
            }
            Console.WriteLine(builder.ToString());
            Console.ReadLine();
        }
    }
}
