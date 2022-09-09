using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043
{
    internal class Program
    {
        public static String RemovingChar(ref string input, ref string input2, ref int count)
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input2[count])
                {
                    i++;
                }
                output += input[i];
            }
            return output;
        }
        static void Main(string[] args)
        {
            string originalWord = "e1MbISaT,IKcA2.";
            string takingOff = "12abc,.";
            Console.WriteLine($"Given word: {originalWord}");
            Console.WriteLine($"Taking off symbols: {takingOff}");
            //string givenWord = originalWord;
            string newWord = originalWord;
            for (int j = 0; j < takingOff.Length; j++)
            {
                newWord = RemovingChar(ref newWord, ref takingOff, ref j);
            }
            
            Console.WriteLine($"Result : {newWord}");
            Console.ReadLine();
        }
    }
}
