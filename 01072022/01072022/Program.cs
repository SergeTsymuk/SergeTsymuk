using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int counter = 0;
             do
             {
                 counter++;
                 Console.WriteLine("Counter {0}", counter);

             } while (counter < 3);
             Console.ReadLine();
             
            */
            decimal counter = 5;
            decimal factorial = 5;
            do
            {
                factorial *= counter--;
               
                                               

            } while (counter > 0);
            Console.WriteLine("Counter {0}", counter);
            Console.ReadLine();
            


            /*
            do
            {
                counter++;
                Console.WriteLine("Counter {0}", counter);

            } while (1 >= 0);
            Console.ReadLine();
            

            byte[] agesList = {23, 30, 35 };
            int index = 0;
            do
            {
                byte agesList = agesList ;
                Console.WriteLine(agesList);

            } while (agesList < 3);
            Console.ReadLine();
            
            byte[] array = new byte[2];

            array[0] = 0;
            array[1] = 1;
            array[2] = 255;
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
            */

            Console.WriteLine("Please enter Number");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            do
            {
                enteredNumber--;
                Console.WriteLine(enteredNumber);
               
            }
            while (enteredNumber > 0) ;
                Console.ReadLine();


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
