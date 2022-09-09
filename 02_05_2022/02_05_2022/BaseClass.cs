using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_2022
{
    abstract class BaseClass
    {
        abstract public void Method(); // => Console.WriteLine("BaseClass.Method");
        public abstract string Property { get; } //{ return "BaseClass.Property"; } }
        public abstract string this[int indexer] { get; } //{ return "BaseClass.Indexer"; } }


    }
}
