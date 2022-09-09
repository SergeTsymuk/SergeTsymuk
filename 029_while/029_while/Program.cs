using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter First Number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                do
                {
                    if ((secondNumber % 2) != 0)
                    {
                        Console.WriteLine(secondNumber);
                    }
                    secondNumber++;
                }
                while (firstNumber != secondNumber);
                Console.ReadLine();
            }
            else
            {
                do
                {
                    if ((firstNumber % 2) != 0)
                    {
                        Console.WriteLine(firstNumber);
                    }
                    firstNumber++;
                }
                while (firstNumber != secondNumber);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
