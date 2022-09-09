using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] month = {"January", "February", "March", "April", "May", "Jun", 
                                "July", "August", "September", "October", "November", "December"};

            foreach (string monthOfYear in month)
            {
                Console.WriteLine(monthOfYear);
            }
            // the same using while 
            /*int index = 0;
            while (index < 12)
            {
                string monthOfYear = month[index];
                Console.WriteLine($" {monthOfYear}");
                index++;
            }*/
            Console.WriteLine("Please Enter Month of the Year in their Order");
            string enteredMonth = Console.ReadLine();
            int index = 0;
            int i = 0;
            do
            {
                do 
                {
                    if (enteredMonth != month[i])
                    {
                        if (i == 4)
                        {
                            Console.WriteLine("May Entered Incorrect, Program STOPPED!");
                            Console.ReadLine();
                            break;
                        }
                        else
                        Console.WriteLine("Please Enter Correct Name of The Month!");
                        Console.ReadLine();
                    }
                    else
                     ++i;
                    Console.WriteLine("Please Enter next Month of the Year in their Order");
                    enteredMonth = Console.ReadLine();
                }
                while (enteredMonth != month[i]);
            } 
            while (index < month.Length);
            {
                Console.WriteLine("Thank you!");
            }
            Console.ReadLine();
        }
    }
}
