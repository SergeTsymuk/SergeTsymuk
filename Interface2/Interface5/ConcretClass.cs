using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface5
{
    internal class ConcretClass : IInterface2
    {
        void IInterface1.Method1() => Console.WriteLine("Method1 - implementation IInterface1");
        void IInterface2.Method2() => Console.WriteLine("Method2 - implementation IInterface2");
    }
}
