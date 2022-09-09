using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01252022
{
    internal class Animal
    {
        protected string Sound { get; set; }
        public void MakeSound() => Console.WriteLine(Sound);
        
    };
}
