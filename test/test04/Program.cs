using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "hello how are you doing?";
            //int counter = 0; //index = 0;

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
            
            Console.ReadLine();

        }
    }
}
