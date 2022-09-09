using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01252022
{
    internal class Dog : Animal
    {
        public Dog() => Sound = "Woof-Woof";
        //public void MakeSound() => Console.WriteLine(Sound);
        public void BringStick() => Console.WriteLine("Bring a stick");
    }
}
