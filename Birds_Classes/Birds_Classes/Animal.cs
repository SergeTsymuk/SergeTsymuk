using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds_Classes
{
    abstract class Animal : IMove
    {
        public abstract string Skin { get ; set ; }
        public abstract void Move();
    }
}
