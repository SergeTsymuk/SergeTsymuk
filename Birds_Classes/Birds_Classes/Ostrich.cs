using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds_Classes
{
    internal class Ostrich : Bird 
    {
        private string size = "Ostrich is Tall";
        public string Size { get { return size; } }
        public override void Fly(string name) => Console.WriteLine($"{name} can't fly.");
    }
}
