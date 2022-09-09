using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    public static class Conv
    {
        public static void ConvertToStr(this int value)
        {
            string str = value.ToString();
            char[] chars = str.ToCharArray();
            string newSt = string.Empty;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '1')
                {
                    newSt += string.Concat("One ");
                }
                if (chars[i] == '2')
                {
                    newSt += string.Concat("Two ");
                }
                if (chars[i] == '3')
                {
                    newSt += string.Concat("Three ");
                }
                if (str[i] == '4')
                {
                    newSt += string.Concat("Four ");
                }
            }
            Console.WriteLine(newSt);
        }
    }
}
