using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 146, 110, 66, 139, 7, 86, 71, 97, 96, 160, 138, 67, 145, 133, 183, 
                               185, 23, 124, 177, 150, 104, 48, 77, 147, 63, 113, 132, 100, 107, 106};
            
            foreach (var item in myArray)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("\n\nPlease press 'ENTER' to start SORTING");
            Console.ReadLine();
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = 0; j < myArray.Length - i - 1; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {     
                        int t = Convert.ToInt32(myArray[j]);
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = t; 
                    }
                }
            }
            foreach (int num in myArray) //Sorted array
            {
                Console.Write("{0}, ", num);
            }
            Console.WriteLine("\n\nPlease press 'ENTER' to Reverce");
            Console.ReadLine();

            int x = 0;
            int[] revArr = new int[myArray.Length];
            for (int i = myArray.Length - 1; i > -1; i--)
            {
                revArr[x] = myArray[i];
                x++;
            }
            foreach (int num in revArr)//Reversed array
            {
                Console.Write("{0}, ", num);
            }
            Console.Read();
        }
    }
    
}
