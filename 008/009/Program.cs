using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float myVer = (float)2.7182818284590452;

            byte b = (byte)myVer;
            sbyte sb = (sbyte)myVer;
            short sh = (short)myVer;
            ushort ush = (ushort)myVer;
            int i = (int)myVer;
            uint ui = (uint)myVer;
            long l = (long)myVer;
            ulong ul = (ulong)myVer;
            float f = (float)myVer;
            double d = myVer;
            decimal dc = (decimal)myVer;


            Console.WriteLine(b);
            Console.WriteLine(sb);
            Console.WriteLine(sh);
            Console.WriteLine(ush);
            Console.WriteLine(i);
            Console.WriteLine(ui);
            Console.WriteLine(l);
            Console.WriteLine(ul);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(dc);

            Console.ReadLine();

        }
    }
}
