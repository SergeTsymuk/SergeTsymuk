using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Switch Calculator");
            Console.WriteLine("Please Enter First number");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter Second number");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter Arithmetic Sign: (+, -, *, /)");
            string arithmeticSign = Console.ReadLine();

            
            switch (arithmeticSign)
            {
                case "+":
                    {
                        Console.WriteLine($"The result is : {firstNumber + secondNumber}");
                    }
                    break;
                case "-":
                    {
                        Console.WriteLine($"The result is : {firstNumber - secondNumber}");
                    }
                    break;
                case "*":
                    {
                        Console.WriteLine($"The result is : {firstNumber * secondNumber}");
                    }
                    break;
                case "/":
                    {
                        Console.WriteLine($"The result is : {firstNumber / secondNumber}");
                    }
                    break;
                default: throw new Exception("Please enter valid Operator");
            }
            Console.ReadLine();

        }
    }
}
