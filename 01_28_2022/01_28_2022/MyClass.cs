using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEXERS
{
    internal class MyClass
    {
        public MyClassArray1 MyArray1 { get; set; }
        public MyClassArray2 MyArray2 { get; set; }

        public MyClass()
        {
            this.MyArray1 = new MyClassArray1();
            this.MyArray2 = new MyClassArray2();
        }
        int[,] array = { { 1, 2, 3, 4, 5},
                        {6, 7, 8, 9, 0}};
        public int this[int index1, int index2]
        {
            get => array[index1, index2];
            set => array[index1, index2] = value;
        }

        public int GetLenght(int lenght)
        {
            return array.GetLength(lenght);
        }
    }
}
