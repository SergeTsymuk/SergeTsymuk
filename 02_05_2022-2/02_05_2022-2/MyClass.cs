using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_2022_2
{
    static class MyClass
    {
        static string variable = null;
        static MyClass() => variable = "Hello world";
        public static void DisplayVariable() => Console.WriteLine(variable);
        public static string Property { set => variable = value; }
        const double PI = 3.14;
    }
}
