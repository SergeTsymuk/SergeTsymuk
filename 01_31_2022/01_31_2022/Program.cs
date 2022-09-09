using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_31_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person();

            person1.Move();
            person1.Talk();

            var person2 = new Person("Ivanov Mike", 42);
            person2.Move();
            person2.Talk();

            Console.ReadLine();
        }
    }
}
