using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test002
{
    internal class Program
    {
    static void Main(string[] args)
        {
            string str = "BBQ and Slaw";
            Console.WriteLine(str.PadLeft(15));  // Displays "   BBQ and Slaw".
            Console.WriteLine(str.PadLeft(5));   // Displays "BBQ and Slaw".

            string str2 = "forty-two";
            char pad = '.';

            Console.WriteLine(str2.PadLeft(15, pad));
            Console.WriteLine(str2.PadLeft(2, pad));
            

            int a = 5;
            //a += 9;
            a /= 4;
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
    // The example displays the following output:
    //       ......forty-two
    //       forty-two
}
