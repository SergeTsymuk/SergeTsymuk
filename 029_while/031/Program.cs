using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleae Enter Integer number!");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            int[] ourArray = {enteredNumber};
            for (int i = 0; i < ourArray.Length; i++)
            {
                Console.WriteLine("Please Enter Integer to fill up an Array");
                ourArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(ourArray);
            Array.Reverse(ourArray);
            Console.WriteLine("Reversed Arrey");
            foreach (int value in ourArray)
            {
                Console.WriteLine(value + " ");
            }
            Console.WriteLine($"\nPlease Enter integer number for a new Elemnt of Array");
            int newElement = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref ourArray, ourArray.Length + 1);
            ourArray[ourArray.Length - 1] = newElement;
            Console.WriteLine("New Arrey");
            foreach (int value in ourArray)
            {
                Console.WriteLine(value + " ");
            }
            Console.ReadKey();
        }
    }
}
