using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_2022_2
{
    class Dog : Animal
    {
        protected override string Name => nameof(Dog);
        public override void MakeSound() => Console.WriteLine("Woof-Woof");

    }
}
