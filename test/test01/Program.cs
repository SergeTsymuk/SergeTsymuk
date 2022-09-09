using System;
using System.Collections.Generic;

namespace test01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("John", 24);
            d.Add("Ann", 18);
            d.Add("Peter", 27);
            string name = "John";
            Console.Write(d[0]);
        }
    }
}
