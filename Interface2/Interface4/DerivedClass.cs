using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface4
{
    internal class DerivedClass : BaseClass, IInterface1, IInterface2
    {
        public void Method1() => Console.WriteLine("Realization Method1 from Iterface1");
        public void Method2() => Console.WriteLine("Realization Method2 from Iterface2");
    }
}
