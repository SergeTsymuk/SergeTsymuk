using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Class1
    {
        private int age;
        private string name;

        public Class1(int age, string name) 
        {
            this.age = age;
            this.name = name;
        }

        public void PrintFields()
        {
            Console.WriteLine($" Age: {age}, Name: {name}");
        }
    }
}
