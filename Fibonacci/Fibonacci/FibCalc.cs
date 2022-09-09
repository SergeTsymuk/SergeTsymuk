using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class FibCalc
    {
        public void FiboRe(int n)
        {
            int a = 0, b = 1, c;
            //if (n >= 0)
            //    //Console.Write(a + " ");
            //if (n >= 1)
            //    //Console.Write(b + " ");
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
                //Console.Clear();
                //Console.WriteLine(c);
            }
        }
    }
}
