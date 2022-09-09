using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEXERS
{
    public class TempRecord
    {
        float[] temps = new float[10]
        {
            56.2F, 56.7F, 56.5F, 56.2F, 56.7F, 56.5F, 56.2F, 56.7F, 56.5F, 49.6F
        };
        public int Length => temps.Length;

        public float this[int index]
        {
            get => temps[index];
            set => temps[index] = value;
        }
    }
    

}
