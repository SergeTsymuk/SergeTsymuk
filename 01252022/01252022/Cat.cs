using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01252022
{
    internal class Cat : Animal
    {
        public Cat() => Sound = "Meow-Meow";
        //public void MakeSound() => Console.WriteLine(Sound);
        public void CatchMouse() => Console.WriteLine("Catch the mouse");
    }
}
