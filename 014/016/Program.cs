using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Word");
            string enteredWord = Console.ReadLine();
            string [] vs = enteredWord.Split(' ');
            Array.Reverse(vs);
            for (int i = 0; i <= vs.Length-1; i++)
            {
                Console.Write(vs[i] + "");            
            }

            
            Console.ReadLine();
        }
    }
}
