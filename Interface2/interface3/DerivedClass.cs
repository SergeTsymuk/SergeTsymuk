using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    internal class DerivedClass : IInterface1, IInterface2
    {
        void IInterface1.Method() => Console.WriteLine("Method1");
        void IInterface2.Method() => Console.WriteLine("Method2");
    }
}
