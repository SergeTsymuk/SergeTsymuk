using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7
{
    internal class MyStack
    {
        private int[] Stack = new int[10];
        private int nextFree = 0;
        public void DisplayMenu()
        {
            Console.WriteLine("Press: '1' to Add to stack");
            Console.WriteLine("Press: '2' to Delete from stack");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1 || userInput == 2)
            {
                switch (userInput)
                {
                    case 1: this.Push();
                        break;

                    case 2: this.Pop();
                        break;
                }
            }
            Console.WriteLine("Wrong ENTRY! Please try again");
        }
        public void Push()
        {
            if (nextFree == Stack.Length)
            {
                Console.WriteLine("Stack is FULL");
                Console.ReadLine();
            }
            Console.WriteLine("Please enter your number to be added");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Stack[nextFree] = userInput;
            nextFree++;
        }
        public void Pop()
        {
            if (nextFree == 0)
            {
                Console.WriteLine("Stack is EMPTY");
                Console.ReadLine();
                this.DisplayMenu();
            }
           nextFree--;
           Stack[nextFree] = 0;
           Console.Clear();
           Console.WriteLine("\nItem was DELITED.");
           this.ShowArray();
           this.DisplayMenu();
        }
        public void ShowArray()
        {
            Console.WriteLine("\nCurrent Stock:");
            foreach (int elements in Stack)
            {
                Console.Write($"{elements} ");
            }
            Console.WriteLine();
        }
    }
}
