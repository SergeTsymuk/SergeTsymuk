using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool retired = true; bool working = true; bool unemployed = true;

            bool subsidyAllowed = (unemployed && retired || !working && !retired && unemployed);
            Console.WriteLine(subsidyAllowed);
            Console.ReadLine();

        }
    }
}
