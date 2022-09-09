using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polindrom2
{
    public class Converter
    {
        public string ConvertStr(string str)
        {
            char[] word = str.ToCharArray();
            Array.Reverse(word);
            string result = string.Empty;
            foreach (var item in word)
            {
                result += item;
            }
            return result;
        }
    }
}
