using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please Enter First Number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int missingNumber = (secondNumber - firstNumber);
            Console.WriteLine($"{secondNumber} = {firstNumber} + {missingNumber}");
            Console.ReadKey();

        }
    }
}
