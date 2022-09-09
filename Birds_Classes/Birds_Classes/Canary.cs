using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds_Classes
{
    internal class Canary : Bird
    {
        private string color = "Canary is Yellow";
        public string Color { get { return color; } }

        public void Sing() => Console.WriteLine("I am a canary and I can sing");

    }
}
