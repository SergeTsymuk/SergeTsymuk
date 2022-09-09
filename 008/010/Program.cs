using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0; int j = 0; int k = 0;
            int s = ((i / j + k));     //   zero / zero = NaN
            int t = 4;
            int p = (t + s);  // 4 + NaN = NaN
            int sub = (t - s);  // 4 - NaN = NaN
            int d = (t / s);  // 4 / NaN = NaN
            int m = (t * s);  // 4 * NaN = NaN
        }

        public const double PositiveInfinity = Infinity;
            Console.ReadLine();
        }
    }
}
