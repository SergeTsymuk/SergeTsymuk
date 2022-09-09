using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_047
{
    internal class Program
    {
        public static String ConvertToUpperCase(String input)
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    output += (char)(input[i] - 'A' + 'a');
                }
                else
                    output += input[i];
            }
            return output;
        }

        static void Main(string[] args)
        {
            Console.Write("Please Enter a string: ");
            String input = Console.ReadLine();
            input = ConvertToUpperCase(input);
            Console.WriteLine("Converted String in Lower Case: " + input);
            Console.ReadLine();
        }
    }
}
