using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class Class1
    {
        private string name;
        private int age;

        public Class1()
        {
            name = "Petrov";
            age = 25;
        }

        public void PrintFields()
        {
            Console.WriteLine($" Age: {age}, Name: {name}");
        }
    }
}
