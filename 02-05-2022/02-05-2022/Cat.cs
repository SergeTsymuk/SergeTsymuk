using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_2022
{
    internal class Cat : Animal
    {
        string Animal.Name => nameof(Cat);
        public void MakeSound() => Console.WriteLine("Meow-Meow");
    }
}
