using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cat
    {
        protected override string Name => nameof(Cat);
        public override void MakeSound() => Console.WriteLine("Meow-Meow");

    }
}
