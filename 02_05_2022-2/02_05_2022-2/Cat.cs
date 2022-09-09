using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_2022_2
{
    class Cat : Animal
    {
        protected override string Name => nameof(Cat);
        public override void MakeSound() => Console.WriteLine("Meow-Meow");

    }
}
