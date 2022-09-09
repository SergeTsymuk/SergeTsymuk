using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds_Classes
{
    class Fish : Animal
    {
        public override string Skin { get; set; }
        public override void Move() => Console.WriteLine("I am moving in water");
    }
}
