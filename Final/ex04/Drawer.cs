using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
    public class Drawer
    {
        public void Converting(int number)
        {
            string recNumber = Convert.ToString(number);
            char[] chars = recNumber.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case '1':
                        Console.Write('A');
                        break;
                    case '2':
                        Console.Write('B');
                        break;
                    case '3':
                        Console.Write('C');
                        break;
                    case '4':
                        Console.Write('D');
                        break;
                    case '5':
                        Console.Write('E');
                        break;
                }
            }
            
        }
        public void DrawPicture(int number)
        {
            number--;
            Console.Write(number);
            
            if (number != 0)
            DrawPicture(number);
            
            Console.Write(number);
            
        }
    }
}
