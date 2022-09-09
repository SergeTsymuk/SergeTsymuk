using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds_Classes
{
    class Bird : Animal, IBreath
    {
        private string wings => "I am a bird and I have wings";
        private string feather => "I am a bird and have a Color feather";
        public override string Skin { get; set; }
        public string? Wings { get; set; } 
        public string? Feather { get; set;}
        public void Breath() => Console.WriteLine("I Can breath");
        public override void Move() => Console.WriteLine("I am bird I can move");
        public virtual void Fly(string name) => Console.WriteLine($"{name} is flying.");
    }
}
