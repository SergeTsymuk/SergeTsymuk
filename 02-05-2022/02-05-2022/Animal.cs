using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_2022
{
    interface Animal
    {
        protected abstract string Name { get; }
        public abstract void MakeSound();
        public void Run(Animal animal) => Console.WriteLine($"The {animal.Name} is running");
    }
}
