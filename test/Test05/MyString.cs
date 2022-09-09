using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test05
{
    public class MyString
    {
        public void ReverseString(string text)
        {
            string reversed = string.Empty;
            for (int i = text.Length -1; i > -1; i--)
            {
                reversed += text[i];
            }
            Console.WriteLine(reversed);
        }
    }
}
