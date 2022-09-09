using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface7
{
    class ConcretClass : IInterface2, IInterface1
    {
        public void Method() => Console.WriteLine("Method - implementation IInterface (1-2)");
    }
}
