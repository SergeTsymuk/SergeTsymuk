using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee tom = new Employee("Tom", "White", "C# Developer", 1256881466, "IT-Tech", 98654.54);
            Worker sam = new Worker("Sam", "Short", "C# Engineer", 1256881466);
            Man stive = new Man("Stive", "Brown");
            
            // by changing names: tom, sam, stive we change realization of classes
            tom.PrintToConsole();
            Console.ReadLine();
        }
    }
}
