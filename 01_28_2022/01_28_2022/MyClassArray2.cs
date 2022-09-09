using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEXERS
{
    internal class MyClassArray2
    {
        int[] array = { 1, 2, 3, 4, 5 };
        public int this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }
    }
}
