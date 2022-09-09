using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_2022
{
    internal class DerivedClass : BaseClass
    {
        public override void Method() => Console.WriteLine("DerivedClass.Method");
        public override string Property => "DerivedClass.Property";
        public override string this[int indexer] => "DerivedClass.Indexer";
    }
}
