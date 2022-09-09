using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _048_053
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your text.");
            string text = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    counter++;
                }
            }
            int[][] array = new int[counter+1][];
            int[] sizeOfArreys = new int[counter]; // saving lenght of all words from text

            int x = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    sizeOfArreys[x] = i;
                    x++;
                }
            }
            
            for (int i = 0; i < text.Length; i++)
            {
                if
            }
            
            Console.WriteLine($"Number of Words:  {counter+1}");
            for (int i = 0; i < sizeOfArreys.Length; i++)
            {
                Console.WriteLine(sizeOfArreys[i]);
            }

            Console.ReadLine();
        }
    }
}
