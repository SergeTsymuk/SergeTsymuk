using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a sentence: ");
            string originalString = Console.ReadLine();
            string secondWord = string.Empty;
            for (int i = 0; i < originalString.Length - 1; i++)
            {
                if (originalString[i] == ' ')
                {
                    ++i;
                    while (originalString[i] != ' ')
                    {
                        secondWord += originalString[i];
                        i++;
                    }
                    Console.WriteLine(secondWord);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
