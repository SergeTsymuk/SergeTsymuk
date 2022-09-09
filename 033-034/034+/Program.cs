using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {108, 91, 122, 114, 62, 182, 110, 73, 167, 67, 24, 74, 116, 120, 42, 171, 52, 46,
                23, 31, 146, 169, 161, 178, 90, 44, 142, 133, 184, 115};

            foreach (var item in myArray)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("\n\nPlease press 'ENTER' to start REVERCE Numbers in Array");
            Console.ReadLine();
            int[] newArray = new int [myArray.Length];
            int s = myArray.Length - 1;
            for (int i = 0; i < myArray.Length; i++)
            {
                newArray[s] = myArray[i];
                s--;
            }
            
            //array with reverced numbers
            foreach (int num in newArray)
            {
                Console.Write("{0}, ", num);
            }
            Console.Read();

        }
    }
}
