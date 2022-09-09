using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Class1
    {
        private int age = 20;
        private string name = "Ivan";

        public void PrintFields()
        {
            Console.WriteLine($" Age: {age}, Name: {name}");
        }
    }
}
