using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        int romanToInt(string s)
        {
            // create a hash map/dictionary to translate chars to integers
            var map = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

            // then iterate the string summing all values and keeping track of the previous value.
            int result = 0;
            int last = int.MaxValue, cur = 0;
            for (int i = 0; i < s.Length; i++)
            {
                cur = map[s[i]];
                // when the previous value is less, substract from the result and from the current value.
                if (last < cur)
                {
                    result -= last;
                    cur -= last;
                }

                result += cur;
                last = cur;
            }
            return result;
        }
            Console.ReadLine();
    }
}
}


