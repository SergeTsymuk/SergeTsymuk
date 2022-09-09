using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true) 
            {     
            Console.WriteLine("Please Enter your number, must be integer");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            int number = enteredNumber;
            int nreversed = 0;
                while (enteredNumber != 0)
                {
                    nreversed *= 10;
                    nreversed += enteredNumber % 10;
                    enteredNumber /= 10;
                }
            if (number == nreversed)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            }
        }
    }
}
