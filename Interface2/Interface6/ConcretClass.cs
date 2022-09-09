using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface6
{
    internal class ConcretClass : IInterface2
    {
        void IInterface1.Method() => Console.WriteLine("Method - implementation IInterface1");
        void IInterface2.Method() => Console.WriteLine("Method - implementation IInterface2");
    }
}
