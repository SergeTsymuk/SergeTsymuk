using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01232022
{
    internal class Person
    {
        public string name;
        public int age;
        public void PrintToConsole()
        {
            Console.WriteLine($"Name is: {name}");
            Console.WriteLine($"Age is: {age}");
        }
        public Person()
        {
            name = "Alex";
            age = 30;
        }
        public Person(string n, int a)
        {
            name = n;
            age = a;
        }
    }
}
