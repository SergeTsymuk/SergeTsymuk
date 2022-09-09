using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal class DerivedClass : IInterface1, IInterface2
    {
        public void Method1() => Console.WriteLine("Method1");
        public void Method2() => Console.WriteLine("Method2");
    }
}
