using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Word");
            string s1 = Console.ReadLine();
            
            var builder = new StringBuilder();
            for (int i = 0; i < s1.Length; i++)
            {
                builder.Append(s1[i]+"-"+s1[i]);
            }
            Console.WriteLine(builder.ToString());
            Console.ReadLine();
        }
    }
}
